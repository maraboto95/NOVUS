using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Bolas : MonoBehaviour {

    public int ballsNum;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ballsNum = countBalls();
        endGame();
	}

    private int countBalls()
    {
        return GameObject.FindGameObjectsWithTag("Largest Ball 1").Length +
            GameObject.FindGameObjectsWithTag("Largest Ball 2").Length +
            GameObject.FindGameObjectsWithTag("Largest Ball").Length +
            GameObject.FindGameObjectsWithTag("Large Ball 1").Length +
            GameObject.FindGameObjectsWithTag("Large Ball 2").Length +
            GameObject.FindGameObjectsWithTag("Large Ball").Length +
            GameObject.FindGameObjectsWithTag("Medium Ball 1").Length +
            GameObject.FindGameObjectsWithTag("Medium Ball 2").Length +
            GameObject.FindGameObjectsWithTag("Medium Ball").Length +
             GameObject.FindGameObjectsWithTag("Small Ball 1").Length +
            GameObject.FindGameObjectsWithTag("Small Ball 2").Length +
            GameObject.FindGameObjectsWithTag("Small Ball").Length;
    }

    void endGame()
    {
        if(ballsNum == 0)
        {

            /* AQUI VA EL SCRIPT DE GANAR EL JUEGO */
            PasarNivelScript.script.GanoPerd(true, "bolas");


        }
    }
}
