﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform bird;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bird != null)
       transform.position =new Vector3( bird.transform.position.x,transform.position.y, transform.position.z);
    }
}
