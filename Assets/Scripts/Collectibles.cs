using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private bool key_picked_up = false;
    [SerializeField] private bool collectible2_picked_up = false;
    [SerializeField] private bool Collectible3_picked_up = false;

    [SerializeField] private GameObject gate1;

    private void Start()
    {
        if (key_picked_up)
        {
            gate1.SetActive(false);
        }
    }

    public void pickedUpKey()
    {
        key_picked_up = true;
        gate1.SetActive(false);
    }
}
