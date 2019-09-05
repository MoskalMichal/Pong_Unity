﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall2_Controller : MonoBehaviour
{
    private Rigidbody2D rb;


    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //Controller Player1
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0f, 10f);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0f, -10f);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }
}
