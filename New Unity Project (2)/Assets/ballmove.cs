using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool InPlay;
    public Transform paddle;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        rb.AddForce(Vector2.up * 500);
    }

    // Update is called once per frame
    void Update()
    {
        if(InPlay == false){
            transform.position = paddle.position;
        }
        if(Input.GetButtonDown("Jump") && !InPlay) {
            InPlay = true;
            rb.AddForce(Vector2.up * 500);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("bottom")){
            Debug.Log("we hit the bottom");
            rb.velocity = Vector2.zero;
            InPlay = false;
        }
    }
}
