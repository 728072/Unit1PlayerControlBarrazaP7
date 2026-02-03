using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnspeed = 45.0f;
    public float HorizontalInput;
    public float VerticalInput;

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);
        transform.Rotate(Vector3.up, turnspeed * HorizontalInput * Time.deltaTime);
    }
}