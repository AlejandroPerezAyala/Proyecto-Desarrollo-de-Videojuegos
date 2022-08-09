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
    private float cameraKey = 0f;
    //private float cameraAxis = 0f;

    [SerializeField] Transform Character;
    
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
        RotatePlayer();
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

    //metodo para el movimiento
    void Direction(Vector3 Movement)
    {
        transform.Translate(Movement* Time.deltaTime * Velocidad);
    }

    //metodo para el movimiento del jugador con las teclas
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

    //Metodo para girar el player sobre si mismo apretando las flechas
    void RotatePlayer()
    {
        //cameraAxis += Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            cameraKey -= 1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            cameraKey += 1;
        }

        //transform.rotation = Quaternion.Euler(0, cameraAxis, 0);

        Character.rotation = Quaternion.Euler(0, cameraKey, 0);
    }


}
