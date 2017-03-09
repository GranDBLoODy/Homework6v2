using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework6 : MonoBehaviour
{
    public float Speed;
    private Rigidbody _rigidbody;

    // Use this for initialization

    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            transform.position = position;
        }
            if (Input.GetKey(KeyCode.V))
        {
            Vector3 position = transform.position;
            position.x--;
            transform.position = position;

        }
            if (Input.GetKey(KeyCode.U)) {
            Vector3 position = transform.position;
            position.z++;
            transform.position = position;
        }
            
            if (Input.GetKey(KeyCode.P)) {
            Vector3 position = transform.position;
            position.z--;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 position = transform.position;
            position.y++;
            transform.position = position;
        }
        }
    }