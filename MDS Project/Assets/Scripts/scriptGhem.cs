﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptGhem : MonoBehaviour {

    // Use this for initialization
    Rigidbody2D mRbody;             // Pt iulian, m-ul din fata e o conventie ca datele membru sa fie cu m , te pup :*  . 

    void Start()
    {
        mRbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            mRbody.AddForce(new Vector2(300, 800));
        }

    }
}
