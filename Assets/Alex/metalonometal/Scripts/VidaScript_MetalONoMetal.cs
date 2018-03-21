using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaScript_MetalONoMetal : MonoBehaviour {

    public static VidaScript_MetalONoMetal vidas;
    public int vidaRestante;
    public int rockNum;

	// Use this for initialization
	void Awake () {
        vidas = this;
        vidaRestante = 3;
        

	}
	
	// Update is called once per frame
	void Update () {
        restartGame(vidaRestante);
        rockNum = countRocks();
        endGame();
    }

    public void bajarVida()
    {
        vidaRestante--;


        if(vidaRestante == 2)
        {
            Destroy(GameObject.FindGameObjectWithTag("vida1"));
        }
        if (vidaRestante == 1)
        {
            Destroy(GameObject.FindGameObjectWithTag("vida2"));
        }
        if (vidaRestante == 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("vida3"));
        }

    }

    void restartGame(int vidas)
    {
        if(vidas == 0)
        {
            /* AQUI VA EL SCRIPT DE PERDER EL JUEGO */
            PasarNivelScript.script.GanoPerd(false, "metal");
        }
    }

    private int countRocks()
    {
        return GameObject.FindGameObjectsWithTag("Metal").Length +
            GameObject.FindGameObjectsWithTag("NoMetal").Length +
            GameObject.FindGameObjectsWithTag("SmallMetal").Length +
            GameObject.FindGameObjectsWithTag("SmallNoMetal").Length +
            GameObject.FindGameObjectsWithTag("SmallestMetal").Length +
            GameObject.FindGameObjectsWithTag("SmallestNoMetal").Length;


    }

    void endGame()
    {
        if (rockNum == 0)
        {

            /* AQUI VA EL SCRIPT DE GANAR EL JUEGO */
            PasarNivelScript.script.GanoPerd(true, "metal");


        }
    }



}
