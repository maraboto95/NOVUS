using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dificultad : MonoBehaviour {

    public Button bf, bm, bd;
    public int dif;

	// Use this for initialization
	void Start () {
        dif = PlayerPrefs.GetInt("dificultad");
	}
	
	// Update is called once per frame
	void Update () {
        bf.onClick.AddListener(taskOnClickF);
        bm.onClick.AddListener(taskOnClickM);
        bd.onClick.AddListener(taskOnClickD);
	}

    void taskOnClickF()
    {
        PlayerPrefs.SetInt("dificultad", 0);
        SceneManager.LoadScene("juego_tabla");
    }

    void taskOnClickM()
    {
        PlayerPrefs.SetInt("dificultad", 1);
        SceneManager.LoadScene("juego_tabla");
    }

    void taskOnClickD()
    {
        PlayerPrefs.SetInt("dificultad", 2);
        SceneManager.LoadScene("juego_tabla");
    }
}
