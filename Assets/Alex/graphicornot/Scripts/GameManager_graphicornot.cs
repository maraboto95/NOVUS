using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager_graphicornot : MonoBehaviour {

    public static GameManager_graphicornot script;
    public Text guiText;

    bool buena;
    int corr;

	void Awake () {
        script = this;
        mandarEcuacionYGrafica();
       
    }
	
	void Update () {
		
	}

    void mandarEcuacionYGrafica()
    {
        corr = Random.Range(0, 20);
        int y = Random.Range(0, 2);

        switch (y)
        {
            case 0: buena = false;
                break;
            case 1: buena = true;
                break;
        }

        GraficaScript_graphicornot.script.ponerGrafica(corr);
        PreguntaScript_graphicornot.script.ponerEcuacion(corr, buena);
    }

    public void clickBoton(bool siono)
    {
        if(siono == buena)
        {
            OnGUI2D_graphicornot.OG2D.SumarScore();
            mandarEcuacionYGrafica();

        }
        else
        {
            VidaScript_graphicornot.script.vidasmenos();
            StartCoroutine(ShowMessage(PreguntaScript_graphicornot.script.ecuaciones[corr,0], 3));
        }

    }

    IEnumerator ShowMessage(string message, float delay)
    {

        guiText.text = message;
        guiText.enabled = true;
        yield return new WaitForSeconds(delay);
        guiText.enabled = false;
        mandarEcuacionYGrafica();

    }



}
