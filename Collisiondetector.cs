﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiondetector : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "player")
        {
            
        }
    }

}


