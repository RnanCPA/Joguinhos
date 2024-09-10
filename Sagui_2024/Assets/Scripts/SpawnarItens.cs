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
    void Update()
    {
        if(gc.GameLigado == true)
        {
            Spawnar();
        }
    }

    public void Spawnar()
    {
        Timer += Time.deltaTime;

        if (Timer > 4.5f)
        {
            int randomI = Random.Range(0, Itens.Count);
            GameObject Vaca = Instantiate(Itens[randomI], transform.position,Quaternion.identity);

            Timer = 0;
        }
    }

}
