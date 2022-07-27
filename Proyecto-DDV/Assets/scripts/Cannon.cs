using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject PrefabBullet;
    public int DelayTime;
    public int SpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PrefabCreate", DelayTime, SpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrefabCreate()
    {
        Instantiate(PrefabBullet, transform);
    }
}
