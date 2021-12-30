using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private Camera Cam;
    public float ZoomSpeed;
    public KeyCode Zbutton;
    void Start()
    {
        Cam = GetComponent<Camera>();
    }

    void Update()
    {

    }
    void fixedupdate()
    {
        if (Input.GetKey(Zbutton))
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 4, Time.deltaTime * ZoomSpeed);
        }
        else
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 9, Time.deltaTime * ZoomSpeed);
        }
    }
}