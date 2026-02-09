using System;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset1 = new Vector3(0, 5, -7);
    private Vector3 offset2 = new Vector3(0, 2, 1);

    private Boolean XisActive;
    private Boolean ZisActive;
    private void Start()
    {
        XisActive = true;
}
    void LateUpdate()
    {

        if (Input.GetKey(KeyCode.Z))
        {
            XisActive = false;
            ZisActive = true;
        }
        if (Input.GetKey(KeyCode.X))
        {
            ZisActive = false;
            XisActive = true;
        }

        if (XisActive == true)
        {
            transform.position = player.transform.position + offset1;
        }

        if (ZisActive == true)
        {
            transform.position = player.transform.position + offset2;
        }
    }
}
