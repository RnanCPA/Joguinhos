using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

    public GameObject Alvo;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    public void Mover()
    {
        transform.position = Vector2.MoveTowards(transform.position, Alvo.transform.position, Speed);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
        }
    }

}
