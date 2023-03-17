using UnityEngine;

public class ObjectMovement : MonoBehaviour
{

    public Transform [] m_targetsToMove;
    public float speed = 5f; // The speed at which the object will move
    private Vector3 direction; // The direction in which the object will move

    void Start()
    {
        // Set the initial direction of the object to move forward along the X-axis
        direction = Vector3.right;
    }

    void Update()
    {
        foreach (Transform t in m_targetsToMove) {
            // Get the input from the player to change the direction of the object's movement
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
            direction = new Vector3(horizontalInput, 0f, verticalInput).normalized;

            // Move the object in the direction of movement at the specified speed
            t.Translate(direction * speed * Time.deltaTime, Space.Self);
        }
       
    }
}