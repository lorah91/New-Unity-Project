using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCube : MonoBehaviour
{
    public float speed = 2f;
    public float jumpSpeed = 20f;

    Rigidbody body;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = speed * Input.GetAxis("Horizontal");
        float y = body.velocity.y;
        float z = speed * Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space)) {
            y = jumpSpeed;
        }

        body.velocity = new Vector3(x, y, z);
    }
}