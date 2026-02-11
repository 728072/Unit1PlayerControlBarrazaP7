using System;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // X key
    public GameObject camera2;
    // Z key
    public GameObject camera1;
    // c key
    public GameObject camera3;
    // v key
    public GameObject camera4;

    private void Start()
    {

        camera1.SetActive(true);
    }
    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.X))
        {
            camera1.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(false);
            camera2.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(false);
            camera1.SetActive(true);
        }
        if (Input.GetKey(KeyCode.C))
        {
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera4.SetActive(false);  
            camera3.SetActive(true);
        }
        if (Input.GetKey(KeyCode.V))
            {
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(true);
        }
    }
}