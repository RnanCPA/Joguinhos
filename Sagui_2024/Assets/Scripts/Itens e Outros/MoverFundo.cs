using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverFundo : MonoBehaviour
{
    private GameController gc;

    public float Meutempo;
    public Vector3 start;

    public int end;
    public int ajuste;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        start = new Vector3(transform.position.x, transform.position.y,0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gc.GameLigado == true)
        {
            Movimento();
        }
    }

    public void Movimento()
    {
        Meutempo += Time.fixedDeltaTime;

        if (Meutempo > 0.1f)
        {
            transform.position = transform.position + new Vector3(speed, 0, 0);
            Meutempo = 0;
        }

        if (transform.position.x < end)
        {
            transform.position = new Vector3(start.x + ajuste, start.y, 0);
        }
    }

}
