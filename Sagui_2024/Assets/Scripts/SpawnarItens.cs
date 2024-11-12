using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnarItens : MonoBehaviour
{

    private GameController gc;

    public List<GameObject> Itens;
    public float Timer;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(gc.GameLigado == true)
        {
            Spawnar();
        }
    }

    public void Spawnar()
    {
        Timer += Time.fixedDeltaTime;

        if (Timer > 5f)
        {
            int sorteio = Random.Range(0, 10);
            if(sorteio <= 4)
            {
                int randomI = Random.Range(0, Itens.Count);
                if (randomI == 2)
                {
                    if (gc.Vidas < 3)
                    {
                        GameObject item = Instantiate(Itens[randomI], transform.position, Quaternion.identity);
                    }
                }
                else
                {
                    GameObject item = Instantiate(Itens[randomI], transform.position, Quaternion.identity);
                }
            }
            Timer = 0;  
        }
    }

}
