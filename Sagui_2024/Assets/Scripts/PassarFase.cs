using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.IK;
using UnityEngine.SceneManagement;

public class PassarFase : MonoBehaviour
{
    private GameController gc;

    public float AvancarFase;
    public float Contador;
    public int _fase;

    public GameObject TelaJogo;
    public GameObject TransicaoFases;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        Contador += Time.deltaTime;

        if (Contador > 2)
        {
            AvancarFase++;
            Contador = 0;
        }

        if(AvancarFase > 60)
        {
            AtivarTransicao();
        }
    }

    void AtivarTransicao()
    {
        gc.GameLigado = false;
        TelaJogo.SetActive(false);
        TransicaoFases.SetActive(true);
    }

    public void ProxFase()
    {
        if (_fase == 1)
        {
            SceneManager.LoadScene(2);
        }
        if (_fase == 2)
        {
            SceneManager.LoadScene(3);
        }
        if (_fase == 3)
        {
            SceneManager.LoadScene(1);
        }
    }
}
