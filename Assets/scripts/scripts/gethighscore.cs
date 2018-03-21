using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gethighscore : MonoBehaviour {

    public TextMesh a, b, c, d, e;

	// Use this for initialization
	void Start () {
        a.text = a.text + " Puntos: " + PlayerPrefs.GetInt("juego_tablascore");
        b.text = b.text + " Puntos: " + PlayerPrefs.GetInt("juego_tabla2score");
        c.text = c.text + " Puntos: " + PlayerPrefs.GetInt("juego_drscore");
        d.text = d.text + " Puntos: " + PlayerPrefs.GetInt("juego_particulasscore");
        e.text = e.text + " Puntos: " + PlayerPrefs.GetInt("juego_graficasscore");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
