using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        Vector3 velocity = Vector3.zero;

        velocity.x = Input.GetAxis("Horizontal");
        velocity.z = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump")) velocity.y = 250;

        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = 7.5f;
        }
        else
        {
            speed = 5.0f;
        }

        transform.position += velocity * speed * Time.deltaTime;
    }
}
