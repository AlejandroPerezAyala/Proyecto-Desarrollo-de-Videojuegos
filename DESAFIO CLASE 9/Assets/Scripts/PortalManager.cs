using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PortalManager : MonoBehaviour
{

    private bool CrossingPortal = true;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("pasaste por el trigger:" + other.gameObject.name);
        ScalePlayer(other);
    }

    void ScalePlayer(Collider Player)
    {
        if (CrossingPortal)
        {
            CrossingPortal = false;
            Player.transform.localScale = Player.transform.localScale / 2;


        }
        else
        if (CrossingPortal == false)
        {
            CrossingPortal = true;
            Player.transform.localScale = Player.transform.localScale * 2;

        }
    }
}
    