using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCountSGT : MonoBehaviour
{
    public static DeathCountSGT Instance { get; private set; }

    public int val = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
