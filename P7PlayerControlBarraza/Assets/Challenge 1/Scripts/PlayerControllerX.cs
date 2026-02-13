using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 15f;
    public float rotationSpeed = 100f;
    public float verticalInput;
    public float horizontalInput;

    public GameObject player;
    public GameObject propeller;
    public bool engineon = false;

    private Rigidbody body;

    private void Start()
    {
        body = player.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.E))
        {
            if (engineon == true)
            {
                engineon = false;
                body.isKinematic = false;
                body.useGravity = true;
            }
        }
            if (Input.GetKey(KeyCode.Q))
            {
                if (engineon == false)
                {
                    engineon = true;
                body.useGravity = false;
                body.isKinematic = true;
                }
            }

            if (engineon == true)
                player.transform.Translate(Vector3.forward * speed * Time.deltaTime);


            if (Input.GetKey(KeyCode.UpArrow))
                if (engineon == true)
                    player.transform.Rotate(-Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
                else return;
            if (Input.GetKey(KeyCode.DownArrow))
                if (engineon == true)
                    player.transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * -verticalInput);
                else return;
            if (engineon == true)
            {
                propeller.transform.Rotate(Vector3.forward * rotationSpeed);
            }
        }
    }