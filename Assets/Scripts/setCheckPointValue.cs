using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setCheckPointValue : MonoBehaviour
{
    public void setValue(int val)
    {
        CheckPointSGT.Instance.val = val;
    }
}
