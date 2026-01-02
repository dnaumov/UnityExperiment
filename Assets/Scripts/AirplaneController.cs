using UnityEngine;

public class AirplaneController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float rotationSpeed = 100f;
    [SerializeField] private float pitchSpeed = 50f;
    [SerializeField] private float rollSpeed = 50f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        rb.useGravity = false;
        rb.isKinematic = true; // Use kinematic mode for direct transform control
    }

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        // Get input from arrow keys
        float horizontal = Input.GetAxis("Horizontal"); // Left/Right arrows
        float vertical = Input.GetAxis("Vertical");     // Up/Down arrows

        // Forward movement (constant)
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // Yaw (Left/Right rotation around Y-axis)
        if (horizontal != 0)
        {
            transform.Rotate(Vector3.up, horizontal * rotationSpeed * Time.deltaTime);
        }

        // Pitch (Up/Down rotation around X-axis)
        if (vertical != 0)
        {
            transform.Rotate(Vector3.right, -vertical * pitchSpeed * Time.deltaTime);
        }

        // Optional: Roll with Q/E keys for more advanced control
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward, rollSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.forward, -rollSpeed * Time.deltaTime);
        }
    }
}
