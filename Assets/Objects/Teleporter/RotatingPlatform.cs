﻿using UnityEngine;
using System.Collections;


public class RotatingPlatform : MonoBehaviour {
    /*void Start()
    {
    }*/
    void Update()
    {
        transform.Rotate(Vector3.up * 2);
    }
    
    void OnCollisionStay(Collision collision)
    {
        
        //collision.transform.Rotate(Vector3.right * 10);
        
    }


}
