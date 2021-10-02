using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowX : MonoBehaviour
{
    private GameObject _player = default;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        var newPosition = transform.position;
        newPosition.x = _player.transform.position.x;
        transform.position = newPosition;
    }
}
