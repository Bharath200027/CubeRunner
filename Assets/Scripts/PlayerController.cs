using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool isAlive = true;
    public float playerSpeed;
    public float horizontalSpeed;
    public Rigidbody rb;
    float horizontalInput;

    [SerializeField] private float jumpVelocity = 350f;
    [SerializeField] private LayerMask GroundMask;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    /*private void FixedUpdate()
    {
        if (isAlive == true)
        {
            Vector3 forward = transform.forward * playerSpeed * Time.fixedDeltaTime;
            Vector3 horizontalMovement = transform.right * horizontalInput * horizontalSpeed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + forward + horizontalMovement);
        }
    }*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpVelocity);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (isAlive == true)
        {
            Vector3 forward = transform.forward * playerSpeed * Time.fixedDeltaTime;
            Vector3 horizontalMovement = transform.right * horizontalInput * horizontalSpeed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + forward + horizontalMovement);
        }
        float playerHeight = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (playerHeight / 2) + 0.1f, GroundMask);
    }
}
