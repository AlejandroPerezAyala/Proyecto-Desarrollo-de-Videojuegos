using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Cannon : MonoBehaviour
{
    public GameObject PrefabBullet;
    public float DelayTime;
    public float SpawnTime;
    

    // Start is called before the first frame update
    void Start()
    {
        Shoot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrefabCreate()
    {
        Instantiate(PrefabBullet, transform.position, transform.rotation);
    }

    void Shoot()
    {
        InvokeRepeating("PrefabCreate", DelayTime, SpawnTime);
    }

   
   

}
