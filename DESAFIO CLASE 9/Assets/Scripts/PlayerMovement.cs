using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Direction(Vector3 Movement)
    {
        transform.Translate(Movement * Time.deltaTime * Velocidad);
    }

    void Movement()
    {

        if (Input.GetKey(KeyCode.W))
        {
            Direction(Vector3.forward);

        }

        if (Input.GetKey(KeyCode.S))
        {
            Direction(Vector3.back);

        }

        if (Input.GetKey(KeyCode.A))
        {
            Direction(Vector3.left);

        }

        if (Input.GetKey(KeyCode.D))
        {
            Direction(Vector3.right);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Vector3.up;
        }
    }
}
