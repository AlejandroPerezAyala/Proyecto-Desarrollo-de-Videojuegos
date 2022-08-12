using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    [Range(0, 2)]
    private float Cooldown;

    [SerializeField]
    Transform[] Teleporters;

    private float TimeTouchWall = 0;

    private bool Touch = true;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Choque con:" + collision.gameObject.name);
        TimeTouchWall = 0;
    }

    private void OnCollisionStay(Collision collision)
    {
        TimeTouchWall += Time.deltaTime;
        if(TimeTouchWall >= Cooldown && Touch)
        {
            if (collision.gameObject.CompareTag("Wall"))
            {
                Touch = false;
                collision.transform.position = Teleporters[0].position;
                collision.transform.rotation = Teleporters[0].rotation;
            }
            
        } else if (TimeTouchWall >= Cooldown && Touch == false)
        {
            if (collision.gameObject.CompareTag("Wall"))
            {
                Touch = true;
                collision.transform.position = Teleporters[1].position;
                collision.transform.rotation = Teleporters[1].rotation;
            }
        }
    }


}
