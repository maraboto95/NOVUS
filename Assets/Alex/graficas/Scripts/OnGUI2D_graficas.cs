using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGUI2D_graficas : MonoBehaviour {

    public static OnGUI2D_graficas OG2D;

   public int score;

	void Awake () {
        OG2D = this;
        score = 0;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score: " + score);
    }	

    public void SumarScore()
    {
        score += 10;
        if(score>= 100)
        {
            /* AQUI VA EL CODIGO DE GANAR EL NIVEL */

            PasarNivelScript.script.GanoPerd(true, "graficas");

        }
    }

  

}

