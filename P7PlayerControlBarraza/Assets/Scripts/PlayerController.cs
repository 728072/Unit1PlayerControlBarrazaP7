using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnspeed = 45.0f;
    private float HorizontalInput;
    private float VerticalInput;

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);
        transform.Rotate(Vector3.up, turnspeed * HorizontalInput * Time.deltaTime);
    }
}