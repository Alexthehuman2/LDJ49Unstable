using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerEnable : MonoBehaviour
{
    public void enabled(bool _enabled)
    {
        this.gameObject.SetActive(_enabled);
    }
}
