using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPassaro : MonoBehaviour
{
    private GameController gc;

    public List<GameObject> Passaros;
    public float Timer;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gc.GameLigado == true)
        {
            Spawnar();
        }
    }

    public void Spawnar()
    {
        Timer += Time.fixedDeltaTime;

        if (Timer > 10f)
        {
            int Sorteio = Random.Range(0, 10);
            if(Sorteio <= 6)
            {
                int randomI = Random.Range(0, Passaros.Count);
                GameObject Vaca = Instantiate(Passaros[randomI], transform.position, Quaternion.identity);
            }

            Timer = 0;
        }
    }
}
