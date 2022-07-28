using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject munition;
    public GameObject munition2;
    public GameObject munition3;
    public GameObject munition4;
    public bool canShoot = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Shoot2();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Shoot3();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Shoot4();
        }
    }


    private void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            Invoke("ResetShoot", 1f);
        }
    }

    private void Shoot2()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition2, transform);
            Invoke("ResetShoot", 1f);
        }
    }

    private void Shoot3()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition3, transform);
            Invoke("ResetShoot", 1f);
        }
    }

    private void Shoot4()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition4, transform);
            Invoke("ResetShoot", 1f);
        }
    }

    private void ResetShoot()
    {
        canShoot = true;
    }
}
