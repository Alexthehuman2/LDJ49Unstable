using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerVolume : MonoBehaviour
{
    public UnityEvent onTriggerEnterEvent = default;
    public UnityEvent onTriggerExitEvent = default;

    private void OnTriggerEnter2D(Collider2D other)
    {
        onTriggerEnterEvent.Invoke();
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        onTriggerExitEvent.Invoke();
    }
}
