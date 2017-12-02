using UnityEngine;


public class CameraZoom : MonoBehaviour
{
    private float _minCameraZoom = 5f;
    private float _maxCameraZoom = 10f;


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
