using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPiso : MonoBehaviour
{

    public float Meutempo;
    public GameObject irmao;
    public float ajuste;

    private GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gc.GameLigado == true)
        {
            Movimento();
        }
    }

    public void Movimento()
    {
        Meutempo += Time.deltaTime;

        if(Meutempo > 0.01f)
        {
            transform.position = transform.position + new Vector3(ajuste, 0, 0);
            Meutempo = 0;
        }

        if(transform.position.x < -25)
        {
            transform.position = new Vector3(irmao.transform.position.x + 23, transform.position.y, 0);
        }
    }

}
