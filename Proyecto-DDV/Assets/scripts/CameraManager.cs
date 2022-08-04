using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject[] Cameras;
    private bool Select = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            CameraSelector();
        }
    }

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
