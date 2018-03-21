using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGUI2D_funciones : MonoBehaviour {

    public static OnGUI2D_funciones OG2D;

   public int score;

	// Use this for initialization
	void Start () {

        OG2D = this;
        score = 0;

	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score: " + score);
    }	

    public void SumarScore()
    {
        score += 5;
        if(score>= 100)
        {
            /* AQUI VA EL CODIGO DE GANAR EL NIVEL */

            PasarNivelScript.script.GanoPerd(true, "funciones");

        }
    }

  

}

