using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Resultado : MonoBehaviour
{
    public Text resultadoFinal;
    private int acertos;
    // Start is called before the first frame update
    void Start()
    {
        acertos = PlayerPrefs.GetInt("acertosTemp");
        resultadoFinal.text = "Resultado: " + acertos.ToString() + " acertos de 10 questoes ";

    }

}
