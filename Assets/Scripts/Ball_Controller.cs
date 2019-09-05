using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Pause());
        
    }

    void Update()
    {
        //position ball after losing

        if (this.transform.position.x >= 8f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }
        
        if(this.transform.position.x <= -8f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }
    }


    //time to new Game
    IEnumerator Pause()
    {

        //counting down to start game
        yield return new WaitForSeconds(3);
        rb.velocity = new Vector2(5f, 5f);

    }
}
