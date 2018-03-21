using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tabla : MonoBehaviour {

    public InputField inp;
    public Text puntos;
    public Text tiempo, completar;
    private int punto;
    private float timeLeft, timeToChange;
    private int minutos;
    private GameObject[] elementos;
    private dificultad difi;
    private int dific;
    private GameObject aux;
    public Button regresar;
    public bool clicked;

	// Use this for initialization
	void Start () {
        inp = GetComponent<InputField>();
        punto = 0;
        clicked = false;
        minutos = 4;
        timeLeft = 59.0f;
        elementos = GameObject.FindGameObjectsWithTag("Element");
        for (int x = 0; x < elementos.Length; x++)
        {
            for(int y = 0; y < elementos.Length; y++)
            {
                if (x == elementos[y].GetComponent<elemento2>().atomic)
                {
                    aux = elementos[x];
                    elementos[x] = elementos[y];
                    elementos[y] = aux;
                }
            }
        }
        dific = PlayerPrefs.GetInt("dificultad");
        switch (dific)
        {
            case 0: for (int x = 31; x < elementos.Length; x++)
                {
                    elementos[x].GetComponent<Text>().color = new Color(0, 0, 0, 1);
                    elementos[x].GetComponent<elemento2>().isCorrect = true;
                }
                break;

            case 1: for(int x = 81; x<elementos.Length; x++)
                {
                    elementos[x].GetComponent<Text>().color = new Color(0, 0, 0, 1);
                    elementos[x].GetComponent<elemento2>().isCorrect = true;
                }
                break;
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
            
            if(timeLeft >= 0 && minutos >= 0)
        {
            timeLeft -= Time.deltaTime;
            tiempo.text = "Tiempo: " + minutos + ":" + Mathf.Round(timeLeft);
            puntos.text = "Puntos: " + punto.ToString();
            if (timeLeft < 0 && minutos > 0)
            {
                timeLeft = 59.0f;
                minutos--;
            }

            foreach (GameObject Element in elementos)
            {
                if (Element.GetComponent<Text>().name.Equals(inp.text.ToLower()))
                {
                    if (Element.GetComponent<elemento2>().isCorrect == false)
                    {
                        Element.GetComponent<Text>().color = new Color(0, 0, 0, 1);
                        inp.text = "";
                        punto++;
                        Debug.Log("Correcto!");
                        Element.GetComponent<elemento2>().isCorrect = true;
                    }
                }
            }
        }
        else
        {
            if (punto >= 30)
            {
                completar.text = "Felicidades! Nivel Completado!";
                PlayerPrefs.SetInt("tabla", 1);
            }

            foreach (GameObject Element in elementos)
            {
                if (Element.GetComponent<elemento2>().isCorrect == false)
                {
                    Element.GetComponent<Text>().color = new Color(255, 0, 0, 1);
                    Element.GetComponent<elemento2>().isCorrect = true;
                }
            }

            timeToChange -= Time.deltaTime;
            if (timeToChange <= 0)
            {
                SceneManager.LoadScene("test_scene");
            }
        }

        regresar.onClick.AddListener(taskOnChange);

        if(clicked == true)
        {
            timeToChange -= Time.deltaTime;

            if (timeToChange <= 0)
            {
                taskOnRegresar();
            }
        }
    }

    void resetElements()
    {
        foreach (GameObject Element in elementos)
        {
                Element.GetComponent<elemento2>().isCorrect = false;
            Element.GetComponent<Text>().color = new Color(0, 0, 0, 0);
        }

        switch (dific)
        {
            case 0:
                for (int x = 31; x < elementos.Length; x++)
                {
                    elementos[x].GetComponent<Text>().color = new Color(0, 0, 0, 1);
                    elementos[x].GetComponent<elemento2>().isCorrect = true;
                }
                break;

            case 1:
                for (int x = 81; x < elementos.Length; x++)
                {
                    elementos[x].GetComponent<Text>().color = new Color(0, 0, 0, 1);
                    elementos[x].GetComponent<elemento2>().isCorrect = true;
                }
                break;
        }
    }

    void taskOnChange()
    {
        clicked = true;
    }

    void taskOnRegresar()
    {
        SceneManager.LoadScene("test_scene");
    }
}
