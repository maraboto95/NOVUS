using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript_pelea2 : MonoBehaviour {

    public static PlayerScript_pelea2 script;

    public float timeLeft;
    public GameObject player;

    void Awake()
    {
        script = this;
        timeLeft = 1;
    }

    void FixedUpdate()
    {
       

    }

    public void avanza1()
    {
        player.transform.position = new Vector3(player.transform.position.x + 1, player.transform.position.y, player.transform.position.z);

        if(player.transform.position.x >= 10)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        //V V V V AQUI VA EL SCRIPT DE GANAR V V V V
        PasarNivelScript.script.GanoPerd(true, "pelea2");
    }


}
