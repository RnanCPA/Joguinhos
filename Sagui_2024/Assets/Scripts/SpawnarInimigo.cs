using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnarInimigo : MonoBehaviour
{
    private GameController gc;

    public List<GameObject> Inimigos;
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

        if(Timer > 5f)
        {
            int indicador = Random.Range(0, Inimigos.Count);

            Vector2 Pos = new Vector2(transform.position.x, transform.position.y + 1f);

            GameObject Vaca = Instantiate(Inimigos[indicador], Pos,
           Quaternion.identity);

            Timer = 0;
        }
    }

}
