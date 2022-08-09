using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    //creo variable publica para seleccionar la cantidad de camaras en el juego
    public GameObject[] Cameras;
    //Booleano para el cambio de camaras
    private bool Select = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Condicion para realizar el cambio de camara con la letra "V"
        if (Input.GetKeyDown(KeyCode.V))
        {
            CameraSelector();
        }
    }

    //Metodo para realizar el cambio de camara
    private void CameraSelector()
    {
        if (Select)
        {
            Select = false;
            Cameras[0].SetActive(true);
            Cameras[1].SetActive(false);
        } else if (Select == false)
        {
            Select = true;
            Cameras[0].SetActive(false);
            Cameras[1].SetActive(true);
        }
    }


}
