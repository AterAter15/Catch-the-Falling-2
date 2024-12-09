using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f; // Movement speed
    public float xLimit = 8f; // Boundary limit

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Get input
        Vector3 movement = new Vector3(horizontalInput, 0, 0) * speed * Time.deltaTime;
        transform.Translate(movement);


        // Clamp the basket within screen boundaries
        float clampedX = Mathf.Clamp(transform.position.x, -xLimit, xLimit);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}
