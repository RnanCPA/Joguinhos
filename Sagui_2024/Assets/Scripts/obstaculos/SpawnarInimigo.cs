using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnarInimigo : MonoBehaviour
{
    private GameController gc;

    public List<GameObject> Inimigos;
    public float Timer;
    public GameObject Chao;

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

        if(Timer > 3f)
        {
            int indicador = Random.Range(0, Inimigos.Count);


            if(Chao.transform.position.x > 9)
            {
                Vector2 Pos = new Vector2(Chao.transform.position.x, Chao.transform.position.y+1.1f);

                GameObject Vaca = Instantiate(Inimigos[indicador], Pos,
               Quaternion.identity);

                if (indicador < 4)
                {
                    Vaca.transform.parent = Chao.transform;
                }

                Timer = 0;
                Destroy(Vaca, 50f);
            }
            
        }
    }

}
