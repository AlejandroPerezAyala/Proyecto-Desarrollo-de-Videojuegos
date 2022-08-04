using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PosY;
    public float PosX;
    public float Velocidad;
    public float Scale;
    int hp = 100;
    public int Attack;
    //public Vector3 Movement;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = Vector3.up * PosY + Vector3.right * PosX;
        transform.localScale = transform.localScale * Scale;
        Damage(Attack);

    }

    // Update is called once per frame
    void Update()
    {

        PlayerMovement();
        Health();
    }

    void Damage(int Attack)
    {
        hp -= Attack;
    }

    void Health()
    {
        hp += 2;
    }

    void Direction(Vector3 Movement)
    {
        transform.Translate(Movement* Time.deltaTime * Velocidad);
    }

    void PlayerMovement()
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
    }

}
