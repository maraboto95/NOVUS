using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tabla2 : MonoBehaviour
{

    public Text tiempo;
    private float timeLeft, timeToChange;
    private int minutos;
    public Button b, skip, regresar;
    public Text textButton, puntos, random, randoms, completar, textButton2;
    private dificultad difi;
    private int dific, aux2;
    private GameObject aux;
    public GameObject[] elementos;
    public int punto, r;
    public bool clicked;

    // Use this for initialization
    void Start()
    {
        b.GetComponent<Button>().interactable = false;
        timeToChange = 2f;
        clicked = false;
        regresar.GetComponent<Button>().interactable = true;
        skip.GetComponent<Button>().interactable = true;
        textButton.GetComponent<Text>().color = new Color(0, 0, 0, 0);
        textButton2.GetComponent<Text>().color = new Color(0, 0, 0, 0);
        puntos.text = "Puntos: " + punto;
        minutos = 4;
        aux2 = 0;
        timeLeft = 59.0f;
        elementos = GameObject.FindGameObjectsWithTag("Element2");
        r = Random.Range(0, elementos.Length);
        for (int x = 0; x < elementos.Length; x++)
        {
            for (int y = 0; y < elementos.Length; y++)
            {
                if (x == elementos[y].GetComponent<elemento3>().atomic)
                {
                    aux = elementos[x];
                    elementos[x] = elementos[y];
                    elementos[y] = aux;
                }
            }
        }
        Debug.Log(elementos[1].name);
        random.text = elementos[r].name;
        randoms.text = elementos[r].GetComponent<elemento3>().symbol;
        randoms.color = new Color(0, 0, 0, 0);
        dific = PlayerPrefs.GetInt("dificultad");
        switch (dific)
        {
            case 0:
                for (int x = 31; x < elementos.Length; x++)
                {
                    elementos[x].GetComponent<Text>().color = new Color(0, 0, 0, 1);
                    elementos[x].GetComponent<elemento3>().isCorrect = true;
                }
                break;

            case 1:
                for (int x = 81; x < elementos.Length; x++)
                {
                    elementos[x].GetComponent<elemento3>().isCorrect = true;
                }
                break;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (timeLeft >= 0 && minutos >= 0)
        {
            b.image.color = new Color(255, 255, 255, 0);
            regresar.image.color = new Color(255, 255, 255, 1);
            textButton2.color = new Color(0, 0, 0, 1);
            regresar.onClick.AddListener(taskOnChange);
            timeLeft -= Time.deltaTime;
            aux2 = 0;
            tiempo.text = "Tiempo: " + minutos + ":" + Mathf.Round(timeLeft);
            foreach (GameObject Element in elementos)
            {
                if (Element.GetComponent<elemento3>().isCorrect == true)
                {
                    aux2++;
                }
            }
            punto = aux2 - 29;
            puntos.text = "Puntos: " + punto;
            if (timeLeft < 0 && minutos > 0)
            {
                timeLeft = 59.0f;
                minutos--;
            }
            skip.GetComponent<Button>().interactable = true;

            skip.onClick.AddListener(roll);
        }
        else
        {
            if (punto >= 20)
            {
                completar.text = "Felicidades! Nivel Completado!";
                PlayerPrefs.SetInt("tabla2", 1);
            }
            b.GetComponent<Button>().interactable = true;
            b.image.color = new Color(255, 255, 255, 1);
            textButton.color = new Color(0, 0, 0, 1);
            textButton2.color = new Color(0, 0, 0, 1);
            b.onClick.AddListener(taskOnClick);
            regresar.onClick.AddListener(taskOnChange);
        }

        if(clicked == true)
        {
            timeToChange -= Time.deltaTime;

            if (timeToChange <= 0)
            {
                taskOnRegresar();
            }
        }
    }

    void taskOnClick()
    {
        minutos = 4;
        timeLeft = 59.0f;
        b.interactable = false;
        regresar.interactable = false;
        punto = 0;
        textButton.GetComponent<Text>().color = new Color(0, 0, 0, 0);
        textButton2.GetComponent<Text>().color = new Color(0, 0, 0, 0);
        resetElements();
    }

    void resetElements()
    {
        foreach (GameObject Element in elementos)
        {
            Element.GetComponent<elemento3>().isCorrect = false;
            Element.GetComponent<Text>().color = new Color(0, 0, 0, 0);
        }

        switch (dific)
        {
            case 0:
                for (int x = 31; x < elementos.Length; x++)
                {
                    elementos[x].GetComponent<Text>().color = new Color(0, 0, 0, 1);
                    elementos[x].GetComponent<elemento3>().isCorrect = true;
                }
                break;

            case 1:
                for (int x = 81; x < elementos.Length; x++)
                {
                    elementos[x].GetComponent<Text>().color = new Color(0, 0, 0, 1);
                    elementos[x].GetComponent<elemento3>().isCorrect = true;
                }
                break;
        }
    }

    void roll()
    {
        elementos[r].GetComponent<elemento3>().isReady = false;
        r = Random.Range(0, elementos.Length);
        random.text = elementos[r].name;
        randoms.text = elementos[r].GetComponent<elemento3>().symbol;
        while (elementos[r].GetComponent<elemento3>().isCorrect == true)
        {
            r = Random.Range(0, elementos.Length);
            random.text = elementos[r].name;
            randoms.text = elementos[r].GetComponent<elemento3>().symbol;
        }
    }

    void taskOnRegresar()
    {
        SceneManager.LoadScene("test_scene");
    }

    void taskOnChange()
    {
        clicked = true;
    }
}
