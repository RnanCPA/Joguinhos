using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public bool GameLigado = false;
    public float Vidas = 3;

    public GameObject TelaJogo;
    public GameObject TelaPause;
    public GameObject TelaOver;

    public float AllSpeed = 1f;
    public float Tempo;

    // Start is called before the first frame update
    void Start()
    {
        GameLigado = false;
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        if(GameLigado == true)
        {
            MaisVelocidade();
        }
    }

    public void IniciarJogo()
    {
        
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void FecharJogo()
    {
        Application.Quit();
    }

    public void Pausar()
    {
        TelaJogo.SetActive(false);
        GameLigado = false;
        TelaPause.SetActive(true);
    }

    public void DesPausar()
    {
        TelaPause.SetActive(false);
        GameLigado = true;
        Time.timeScale = 1;
        TelaJogo.SetActive(true);
    }

    public void MenuInicial()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        TelaJogo.SetActive(false);
        GameLigado = false;
        TelaOver.SetActive(true);
    }

    public void MaisVelocidade()
    {
        Tempo += Time.fixedDeltaTime;

        if(Tempo >= 20f)
        {
            AllSpeed = AllSpeed + 0.05f;
            Tempo = 0;
        }
    }

}
