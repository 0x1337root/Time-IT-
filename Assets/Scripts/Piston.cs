using UnityEngine;

public class Piston : MonoBehaviour
{
    bool isGrounded = false;

    bool isPressed = false;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.touchCount >= 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                isPressed = true;
            }
        }

        if (Input.GetKeyDown("space"))
        {
            isPressed = true;
        }
    }

    void FixedUpdate()
    {
        if (isPressed && !isGrounded)
        {
            rb.velocity = new Vector3(-7, 0, 0);
        }

        if (isGrounded)
        {
            rb.velocity = new Vector3(7, 0, 0);

            if(transform.position.x >= 0.78)
            {
                isGrounded = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Plane")
        {
            isGrounded = true;
            isPressed = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Plane")
        {
            isGrounded = true;
            isPressed = false;
        }
    }
}
