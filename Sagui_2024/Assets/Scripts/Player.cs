using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    public float JumpForce;
    bool PodePular = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Pular();
    }

    public void Pular()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(PodePular == true)
            {
                PodePular = false;
                rb.velocity = new Vector2(rb.velocity.x, JumpForce);
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Piso")
        {
            PodePular = true;
        }
    }

}
