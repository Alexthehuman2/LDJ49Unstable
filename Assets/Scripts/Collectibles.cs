using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private bool key_picked_up = false;
    [SerializeField] private bool key2_picked_up = false;
    [SerializeField] private bool key3_picked_up = false;
    [SerializeField] private AudioSource collectible;
    [SerializeField] private GameObject gate1;
    [SerializeField] private GameObject gate2;
    [SerializeField] private GameObject gate3;
    [SerializeField] private bool debug;

    private void Start()
    {
        if (debug)
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
                    key2_picked_up = true;
                    break;
                case 3:
                    key_picked_up = true;
                    key2_picked_up = true;
                    key3_picked_up = true;
                    break;
                default:
                    break;

            }
        }
        if (key_picked_up)
        {
            gate1.SetActive(false);
        }
        if (key2_picked_up)
        {
            gate2.SetActive(false);
        }
        if (key3_picked_up)
        {
            gate3.SetActive(false);
        }
    }
     
    public void pickedUpKey()
    {
        key_picked_up = true;
        collectible.Play();
        gate1.SetActive(false);
    }
    public void pickedUpKey2()
    {
        key2_picked_up = true;
        collectible.Play();
        gate2.SetActive(false);
    }
    public void pickedUpKey3()
    {
        key3_picked_up = true;
        collectible.Play();
        gate3.SetActive(false);
    }
}
