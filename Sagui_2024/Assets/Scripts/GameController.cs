using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public Animator batataFrita;
    public bool GameLigado = false;
    public float Vidas = 3;
    public float moedas = 0;

    public GameObject TelaJogo;
    public GameObject TelaPause;
    public GameObject TelaOver;

    // Start is called before the first frame update
    void Start()
    {
        GameLigado = false;
        

        if (PlayerPrefs.HasKey("Moeda"))
        {
            moedas = PlayerPrefs.GetFloat("Moeda");
        }
        else
        {
            PlayerPrefs.SetFloat("Moeda", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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

}
