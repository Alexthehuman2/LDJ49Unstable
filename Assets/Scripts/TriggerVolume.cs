using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerVolume : MonoBehaviour
{
    [SerializeField] private string player = "Player";
    [SerializeField] private bool deleteAfterTrigger = false;
    public UnityEvent onTriggerEnterEvent = default;
    public UnityEvent onTriggerExitEvent = default;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if( !other.CompareTag(player) ) return;
        onTriggerEnterEvent.Invoke();
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if( !other.CompareTag(player) ) return;
        onTriggerExitEvent.Invoke();
    }
}
