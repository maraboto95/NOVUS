using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class highscore : MonoBehaviour {

    public int score, high;
    public string activa;
    //public Text prueba;
    public string[] separado;

	// Use this for initialization
	void Start () {
        activa = SceneManager.GetActiveScene().name;
        Debug.Log(PlayerPrefs.GetInt(activa + "score"));
        high = PlayerPrefs.GetInt(activa + "score");
    }
	
	// Update is called once per frame
	void Update () {
        separado = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>().text.Split(':');
        int.TryParse(separado[1], out score);
        if(score > high)
        {
            high = score;
        }
        PlayerPrefs.SetInt(activa + "score", high);
        //prueba.text = PlayerPrefs.GetInt(activa + "score") + " " + separado[0];
    }
}
