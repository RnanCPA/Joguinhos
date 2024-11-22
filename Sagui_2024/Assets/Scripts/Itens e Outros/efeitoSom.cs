using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efeitoSom : MonoBehaviour
{
    public GameObject Audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject som = Instantiate(Audio, transform.position, Quaternion.identity);
            Destroy(som, 0.6f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject som = Instantiate(Audio, transform.position, Quaternion.identity);
            Destroy(som, 0.6f);
        }
    }
}
