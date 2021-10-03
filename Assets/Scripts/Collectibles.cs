using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private bool key_picked_up = false;
    [SerializeField] private bool collectible2_picked_up = false;
    [SerializeField] private bool Collectible3_picked_up = false;
    [SerializeField] private AudioSource collectible;
    [SerializeField] private GameObject gate1;

    private void Start()
    {
        switch (CheckPointSGT.Instance.val)
        {
            case 0:
                break;
            case 1:
                key_picked_up = true;
                break;
            case 2:
                key_picked_up = true;
                collectible2_picked_up = true;
                break;
            case 3:
                key_picked_up = true;
                collectible2_picked_up = true;
                Collectible3_picked_up = true;
                break;
            default:
                break;

        }
        if (key_picked_up)
        {
            gate1.SetActive(false);
        }
    }

    public void pickedUpKey()
    {
        key_picked_up = true;
        collectible.Play();
        CheckPointSGT.Instance.val++;
        gate1.SetActive(false);
    }
}
