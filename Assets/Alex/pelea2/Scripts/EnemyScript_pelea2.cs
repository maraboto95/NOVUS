using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript_pelea2 : MonoBehaviour {

    public static EnemyScript_pelea2 script;

    public float timeLeft;
    public GameObject enemy;

	void Awake () {
        script = this;
        timeLeft = 1;
	}
	
	void FixedUpdate () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            avanza1t();
        }

    }

    void avanza1t()
    {
        float move = 1.0f/3.0f;
        enemy.transform.position = new Vector3(enemy.transform.position.x + move, enemy.transform.position.y, enemy.transform.position.z);
        timeLeft = 1;
        if (enemy.transform.position.x >= 10)
        {
            GameOver();
        }
    }

    public void avanza1()
    {
        enemy.transform.position = new Vector3(enemy.transform.position.x + 1, enemy.transform.position.y, enemy.transform.position.z);

        if (enemy.transform.position.x >= 10)
        {
            GameOver();
        }

    }

    void GameOver()
    {
        //V V V V AQUI VA EL SCRIPT DE PERDER V V V V

        PasarNivelScript.script.GanoPerd(false, "pelea2");
    }


}
