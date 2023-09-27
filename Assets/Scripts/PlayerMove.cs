using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.ProBuilder;
using UnityEngine.UIElements;


public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float rotation_speed;
    public Rigidbody rb;
    public float lookValue;
    Vector2 movementValue;
    public float jumpForce;
    private float jumpCount;
    // Start is called before the first frame update
    void Start()
    {
        jumpCount = 0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>() * speed;
    }

    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * rotation_speed;
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && jumpCount < 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpCount = 5;
        }
        jumpCount -= Time.deltaTime;
    }

    void Update()
    {
        
        rb.AddRelativeForce(movementValue.x * Time.deltaTime, 0 , movementValue.y * Time.deltaTime);

        rb.AddRelativeTorque(0, lookValue * Time.deltaTime, 0);
        Jump();
    }
 
}
