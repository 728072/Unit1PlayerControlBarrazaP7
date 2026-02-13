using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;

    public GameObject player;
    public GameObject propeller;
    public bool engineon;

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (engineon == true)
            {
                engineon = false;
            }
            else engineon = true;
        }
    }
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        if (engineon == true)
            player.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        else return;

        if (Input.GetKey(KeyCode.UpArrow))
            if (engineon == true)
                player.transform.Rotate(-Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
            else return;
        if (Input.GetKey(KeyCode.DownArrow))
            if (engineon == true)
                player.transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * -verticalInput);
            else return;
        if (engineon)
        {
            propeller.transform.Rotate(Vector3.forward * rotationSpeed);
        }
    }
}

