using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newgame : MonoBehaviour {

    public Button b;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        b.onClick.AddListener(resetGame);
	}

    void resetGame()
    {
        PlayerPrefs.SetInt("tabla", 0);
        PlayerPrefs.SetInt("tabla2", 0);
        PlayerPrefs.SetInt("funcrel", 0);
        PlayerPrefs.SetInt("domran", 0);
        PlayerPrefs.SetInt("particulas", 0);
        PlayerPrefs.SetInt("bolas", 0);
        PlayerPrefs.SetInt("enlaces", 0);
        PlayerPrefs.SetInt("funciones", 0);
        PlayerPrefs.SetInt("graficas", 0);
        PlayerPrefs.SetInt("grafno", 0);
        PlayerPrefs.SetInt("metal", 0);
        PlayerPrefs.SetInt("pelea", 0);
        PlayerPrefs.SetInt("pelea2", 0);
        PlayerPrefs.SetInt("pendiente", 0);
    }
}
