using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_graficas : MonoBehaviour
{

    public static GameManager_graficas script;

    public int vidas;
    public bool perder = false;

    void Awake()
    {
        vidas = 6;
        script = this;
    }


    public void bajarVida()
    {
        if (!perder)
        {
            vidas--;
            //PlayerScript.script.subirSprite();

            if (vidas <= 0)
            {
                perder = true;
                GameOver();
            }
        }
    }

    void GameOver()
    {
        if(vidas<=0 || perder)
        {

            PreguntasScript_graficas.script.PonerPerdiste();

            PasarNivelScript.script.GanoPerd(false, "graficas");
        }
    }

}
