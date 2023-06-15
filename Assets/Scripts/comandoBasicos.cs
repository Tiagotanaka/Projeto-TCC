using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class comandoBasicos : MonoBehaviour{
    public void carregaCena(string nomeCena){
        SceneManager.LoadScene(nomeCena);
    } 
    public void fechar()
    {
        Application.Quit();
        // UnityEditor.EditorApplication.isPlaying = false;
    }
}
