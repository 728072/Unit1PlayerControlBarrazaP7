using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
