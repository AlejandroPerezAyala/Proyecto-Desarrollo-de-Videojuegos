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
    public Vector3 Movement;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.up * PosY + Vector3.right * PosX;
        transform.localScale = transform.localScale * Scale;
        Damage(Attack);

    }

    // Update is called once per frame
    void Update()
    {
        Direction(Movement);
        Health();
        Debug.Log(hp);
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
        transform.position = transform.position + Movement* Time.deltaTime * Velocidad;
    }

}
