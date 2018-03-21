using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class VidaScript_graphicornot : MonoBehaviour {

    public static VidaScript_graphicornot script;

    public int vidas;

    public GameObject cora1, cora2, cora3;

    public int timeToChange;

	void Awake () {

        script = this;
        vidas = 3;
	}
	
    public void vidasmenos()
    {
        vidas--;
        if (vidas == 2)
        {
            Destroy(cora1);
        }else if(vidas == 1)
        {
            Destroy(cora2);
        }else if(vidas <= 0)
        {
            Destroy(cora3);

            if(OnGUI2D_graphicornot.OG2D.score >= 70)
            {
                /*SCRIPT DE GANAR*/
                PasarNivelScript.script.GanoPerd(true, "grafno");


            }
            else
            {
                /*SCRIPT DE PERDER*/
                PasarNivelScript.script.GanoPerd(false, "grafno");

            }

        }
    }



    

         

}
