using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OnGUI2D_graphicornot : MonoBehaviour
{

    public static OnGUI2D_graphicornot OG2D;


    public int score;

    void Awake()
    {

        OG2D = this;
        score = 0;

    }

    public GUIStyle myGUIStyle;


    void OnGUI()
    {
        myGUIStyle.fontSize = 20;

        GUI.Label(new Rect(10, 10, 100, 20), "Score: " + score, myGUIStyle);

    }

    public void SumarScore()
    {
        score += 5;
        if (score >= 100)
        {
            /* AQUI VA EL CODIGO DE GANAR EL NIVEL */

            PasarNivelScript.script.GanoPerd(true, "grafno");

        }
    }

    


}

