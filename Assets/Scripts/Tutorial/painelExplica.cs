using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class painelExplica : MonoBehaviour
{
    public GameObject painel;
    public GameObject btns;
    public GameObject peao;
    public GameObject torre;
    public GameObject bispo;
    public GameObject cavalo;
    public GameObject rainha;
    public GameObject rei;
    public GameObject revisao;
    public GameObject informacao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fechaPainel()
    {
        painel.SetActive(false);
        btns.SetActive(true);
        informacao.SetActive(true);
    }

    public void explicaPeao()
    {
        peao.SetActive(true);
        torre.SetActive(false);
        bispo.SetActive(false);
        cavalo.SetActive(false);
        rainha.SetActive(false);
        rei.SetActive(false);
        revisao.SetActive(false);
        informacao.SetActive(false);
    }

    public void explicaTorre()
    {
        peao.SetActive(false);
        torre.SetActive(true);
        bispo.SetActive(false);
        cavalo.SetActive(false);
        rainha.SetActive(false);
        rei.SetActive(false);
        revisao.SetActive(false);
        informacao.SetActive(false);
    }

    public void explicaBispo()
    {
        peao.SetActive(false);
        torre.SetActive(false);
        bispo.SetActive(true);
        cavalo.SetActive(false);
        rainha.SetActive(false);
        rei.SetActive(false);
        revisao.SetActive(false);
        informacao.SetActive(false);
    }

    public void explicaCavalo()
    {
        peao.SetActive(false);
        torre.SetActive(false);
        bispo.SetActive(false);
        cavalo.SetActive(true);
        rainha.SetActive(false);
        rei.SetActive(false);
        revisao.SetActive(false);
        informacao.SetActive(false);
    }

    public void explicaRainha()
    {
        peao.SetActive(false);
        torre.SetActive(false);
        bispo.SetActive(false);
        cavalo.SetActive(false);
        rainha.SetActive(true);
        rei.SetActive(false);
        revisao.SetActive(false);
        informacao.SetActive(false);
    }

    public void explicaRei()
    {
        peao.SetActive(false);
        torre.SetActive(false);
        bispo.SetActive(false);
        cavalo.SetActive(false);
        rainha.SetActive(false);
        rei.SetActive(true);
        revisao.SetActive(false);
        informacao.SetActive(false);
    }
    
    public void explicaRevisao()
    {
        peao.SetActive(false);
        torre.SetActive(false);
        bispo.SetActive(false);
        cavalo.SetActive(false);
        rainha.SetActive(false);
        rei.SetActive(false);
        revisao.SetActive(true);
        informacao.SetActive(false);
    }
}
