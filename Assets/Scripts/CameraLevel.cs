using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLevel : MonoBehaviour
{
    [SerializeField] private int screenHeight = 10;
    
    private Camera _camera = default;
    private GameObject _player = default;
    
    void Start()
    {
        _camera = Camera.main;
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnScreenTransition()
    {
        var cam = _camera.transform.position;
        var player = _player.transform.position;
        var vector = cam.y - player.y;

        if (vector < 0)
        {
            var newCamPos = new Vector3( cam.x, cam.y + screenHeight, -10);
            _camera.transform.position = newCamPos;
            transform.position = newCamPos;
        }
        else
        {
            var newCamPos = new Vector3( cam.x, cam.y - screenHeight, -10);
            _camera.transform.position = newCamPos;
            transform.position = newCamPos;        
        }
    }
    
}
