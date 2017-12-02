using UnityEngine;


public class CameraZoom : MonoBehaviour
{
    private float _minCameraZoom = 21f;
    private float _maxCameraZoom = 32f;


    private void Awake()
    {
        Camera.main.orthographicSize = _minCameraZoom;
    }

    private void SwitchCameraZoom()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (Camera.main.orthographicSize == _minCameraZoom)
                Camera.main.orthographicSize = _maxCameraZoom;
            else
                Camera.main.orthographicSize = _minCameraZoom;
        }
           
    }

    private void Update()
    {
        SwitchCameraZoom();
    }

}
