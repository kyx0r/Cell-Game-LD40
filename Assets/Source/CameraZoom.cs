using UnityEngine;


public class CameraZoom : MonoBehaviour
{
    private float _minCameraZoom = 21f;
    private float _maxCameraZoom = 32f;
    private float _minCamera = 5f;

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
        if (Input.GetAxis("Mouse ScrollWheel") < 0) // forward
        {
            Camera.main.orthographicSize++;
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0) // back
        {
            Camera.main.orthographicSize--;
        }
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, _minCamera, _maxCameraZoom); 
    }

    private void Update()
    {
        SwitchCameraZoom();
    }

}
