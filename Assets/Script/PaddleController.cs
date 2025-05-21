using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;          // Paddle movement speed
    public float boundaryY = 4.5f;    // Limits for paddle movement on Y-axis

    void Update()
    {
        // Get vertical input from keyboard (W/S or Up/Down arrows)
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement vector
        Vector3 movement = new Vector3(0, verticalInput * speed * Time.deltaTime, 0);

        // Apply movement
        transform.Translate(movement);

        // Clamp the position to keep the paddle within bounds
        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(transform.position.y, -boundaryY, boundaryY),
            transform.position.z
        );
    }
}
