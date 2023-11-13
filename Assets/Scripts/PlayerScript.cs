using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float jumpForce;
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(Vector3.forward * movementSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(Vector3.left * movementSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(Vector3.back * movementSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(Vector3.right * movementSpeed);
        }
    }
}
