using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int Velocidad;
    public Vector3 Direction;
    public int Damage;
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
       Movement();
    }

    void Movement()
    {
        transform.position = transform.position + Direction * Time.deltaTime * Velocidad;
    }

   
}
