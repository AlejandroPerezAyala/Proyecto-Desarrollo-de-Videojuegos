using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int Velocidad;
    public Vector3 Direction;
    public int Damage;
    public float LiveTime;
   

    // Start is called before the first frame update
    void Start()
    {

        DestroyBullet();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = transform.localScale * 2;
        } 
       Movement();
    }

    void Movement()
    {
        transform.position = transform.position + Direction * Time.deltaTime * Velocidad;
    }

    void DestroyBullet()
    {
        Destroy(gameObject,LiveTime);
    }
}
