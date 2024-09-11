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

        if(Meutempo > 0.1f)
        {
            Vector2 NewPos = new Vector2(transform.position.x - 1f, transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, NewPos, ajuste);
            Meutempo = 0;
        }

        if(transform.position.x < -26)
        {
            transform.position = new Vector3(irmao.transform.position.x + 22, transform.position.y, 0);
        }
    }

}
