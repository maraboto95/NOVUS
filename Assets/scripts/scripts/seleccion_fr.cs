using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class seleccion_fr : MonoBehaviour {

    public Button funcion, relacion, regresar;
    public bool selectedf, selectedr, clicked;
    public Text t, ganar;
    public int punto;
    public float timeToChange;

	// Use this for initialization
	void Start () {
        punto = 0;
        clicked = false;
        timeToChange = 2f;
        PlayerPrefs.SetInt("puntos", 0);
        PlayerPrefs.SetInt("clicked", 0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            funcion.GetComponent<Image>().color = new Color(255, 0, 0);
            selectedf = true;
            selectedr = false;
            relacion.GetComponent<Image>().color = new Color(255, 255, 255);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            relacion.GetComponent<Image>().color = new Color(255, 0, 0);
            selectedf = false;
            selectedr = true;
            funcion.GetComponent<Image>().color = new Color(255, 255, 255);
        }

        if(PlayerPrefs.GetInt("puntos") == 13)
        {
            ganar.text = "Victoria!!!";
            PlayerPrefs.SetInt("funcrel", 1);
            timeToChange -= Time.deltaTime;
            if(timeToChange <= 0)
            {
                SceneManager.LoadScene("test_scene");
            }
        }
        else
        {
                //timeToChange -= Time.deltaTime;
                if (timeToChange <= 0)
                {
                    ganar.text = "Derrota!!!";
                    SceneManager.LoadScene("juego_graficas");
                }
        }

        funcion.onClick.AddListener(taskOnFuncion);
        relacion.onClick.AddListener(taskOnRelacion);
        punto = PlayerPrefs.GetInt("puntos");
        t.text = "Puntos: " + punto.ToString();

        regresar.onClick.AddListener(taskOnChange);

        if (clicked)
        {
            timeToChange -= Time.deltaTime;

            if (timeToChange <= 0)
            {
                taskOnRegresar();
            }
        }
    }

    void taskOnFuncion()
    {
        funcion.GetComponent<Image>().color = new Color(255, 0, 0);
        selectedf = true;
        selectedr = false;
        relacion.GetComponent<Image>().color = new Color(255, 255, 255);
    }

    void taskOnRelacion()
    {
        relacion.GetComponent<Image>().color = new Color(255, 0, 0);
        selectedf = false;
        selectedr = true;
        funcion.GetComponent<Image>().color = new Color(255, 255, 255);
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
