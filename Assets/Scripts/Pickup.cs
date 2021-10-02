using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public void OnPickUp()
    {
        Destroy(this.gameObject);
    }
}
