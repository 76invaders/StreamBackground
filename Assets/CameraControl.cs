using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraControl : MonoBehaviour
{
    public Slider rotationControl,vievControl;
    private Transform cameraRotation;
    private Camera cameraViev;

    void Start()
    {
        cameraRotation = GetComponent<Transform>();
        cameraViev = GetComponent<Camera>();
    }
    
    void Update()
    {
        cameraRotation.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, rotationControl.value), 1f);
        cameraViev.fieldOfView = vievControl.value;
    }
}
