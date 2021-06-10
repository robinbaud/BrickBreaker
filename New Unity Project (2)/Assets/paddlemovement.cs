using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class paddlemovement : MonoBehaviour
{
    public float speed;
    public float ledge;
    public float redge;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);
        if(transform.position.x < ledge)
            transform.position = new Vector2(ledge, transform.position.y);
        if(transform.position.x > redge)
            transform.position = new Vector2(redge, transform.position.y);
    }  
}