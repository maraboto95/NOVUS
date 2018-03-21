using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGUI2D_enlaces : MonoBehaviour
{

    public static OnGUI2D_enlaces OG2D;

    public int score;

    void Awake()
    {
        OG2D = this;
        score = 0;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score: " + score);
    }

    public void SumarScore()
    {
        score += 15;
        if (score >= 100)
        {
            /* AQUI VA EL CODIGO DE GANAR EL NIVEL */

            PasarNivelScript.script.GanoPerd(true, "enlances");

        }
    }

    public void SumarDiez()
    {
        score += 10;
        if (score >= 100)
        {
            /* AQUI VA EL CODIGO DE GANAR EL NIVEL */

            PasarNivelScript.script.GanoPerd(true, "enlances");

        }
    }
    public void SumarCinco()
    {
        score += 5;
        if (score >= 100)
        {
            /* AQUI VA EL CODIGO DE GANAR EL NIVEL */

            PasarNivelScript.script.GanoPerd(true, "enlances");

        }
    }




}

