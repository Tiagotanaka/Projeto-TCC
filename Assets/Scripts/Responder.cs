using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Responder : MonoBehaviour
{
    
    public Text pergunta;
    public Text respostaE;
    public Text respostaD;
    public Text infoPergunta;

    public GameObject[] figuras;
    public string[] perguntas;
    public string[] respostasEsquerda;
    public string[] respostasDireita;
    public string[] corretas;

    private int idPergunta;
    private int acertos;
    private float questoes;
    private float media;
    private GameObject figura;
    private string teste;

    // Start is called before the first frame update
    void Start()
    {
        idPergunta = 0;
        questoes = perguntas.Length;
        pergunta.text = perguntas[idPergunta];
        figuras[idPergunta].SetActive(true);
        respostaE.text = respostasEsquerda[idPergunta];
        respostaD.text = respostasDireita[idPergunta];
        infoPergunta.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + " perguntas.";
    }

    public void resposta(string alternativa)
    {
        if (alternativa == "A")
        {
            if(respostasEsquerda[idPergunta] == corretas[idPergunta])
            {
                acertos++;
            }
        }
        else if(alternativa =="B")
        {
            if(respostasDireita[idPergunta] == corretas[idPergunta])
            {
                acertos++;
            }
        }
        proximaPergunta();
    }

    void proximaPergunta()
    {
        figuras[idPergunta].SetActive(false);
        idPergunta+=1;
        if(idPergunta <= questoes-1)
        {
            pergunta.text = perguntas[idPergunta];
            figuras[idPergunta].SetActive(true);
            respostaE.text = respostasEsquerda[idPergunta];
            respostaD.text = respostasDireita[idPergunta];
            infoPergunta.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + " perguntas.";
        }
        else
        {
            PlayerPrefs.SetInt("acertosTemp",acertos);
            SceneManager.LoadScene("Resultado");
        }
       

    }
}
