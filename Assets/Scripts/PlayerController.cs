using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private float horizontalInput;
    private float verticalInput;

    private float xRange = 9f;
    private float zRange = 6f;

    

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        PlayerInBounds();
    }

    private void PlayerInBounds()
    {
        Vector3 pos = transform.position;

        if (pos.x < -xRange)
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);
        }

        if (pos.x > xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }

        if (pos.z < -zRange)
        {
            transform.position = new Vector3(pos.x, pos.y, -zRange);
        }

        if (pos.z > zRange)
        {
            transform.position = new Vector3(pos.x, pos.y, zRange);
        }
    }

    
}

