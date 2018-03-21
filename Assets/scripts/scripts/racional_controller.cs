using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class racional_controller : MonoBehaviour
{

    public Image grafica;
    public Text tiempo, punto, num, funcion, resultado;
    public Button skip, regresar;
    private int index, correct, minutos;
    private float timeLeft, timeToPlay, timeToChange;
    public InputField inp, inp2, inp3, inp4;
    public Sprite s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, flecha;
    private Sprite[] grafs;
    private string[] funcs, interx, intery, asix, asiy;
    private bool act, act2, act3, act4, secreto, si2, no2, clicked;
    public SpriteRenderer si, no;

    // Use this for initialization
    void Start()
    {
        index = 0;
        correct = 0;
        minutos = 4;
        clicked = false;
        timeLeft = 59f;
        timeToPlay = -1f;
        timeToChange = 2f;
        secreto = true;
        si.color = new Color(0, 0, 0, 0);
        no.color = new Color(0, 0, 0, 0);
        tiempo.text = "Tiempo: " + minutos + ":" + Mathf.Round(timeLeft);
        punto.text = "Puntos: " + correct;
        resultado.color = new Color(0, 0, 0, 0);
        num.text = (index + 1).ToString();
        grafs = new Sprite[] { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, flecha, flecha, flecha, flecha, flecha, flecha, flecha, flecha, flecha, flecha, flecha, flecha, flecha };
        funcs = new string[] { "(4x-4)/(x+2)", "(4-3x)/(x+7)", "18/(x-3)^2", "(4x-8)/(x-4)(x+1)", "6/(x^2-5x-6)", "(3x+6)/(x^2+2x-8)", "(x-1)(x+2)/(x+1)(x-3)", "(x^2-2x+1)/(x^2+2x+1)", "(2x^2+10x-12)/(x^2+x-6)", "(x^2-x-6)/(x^2+3x)", "(3x^2+6)/(x^2-2x-3)", "(x^2-2x+1)/(x^3-3x^2)", "(2x+6)/(-6x+3)", "(1-2x)/(2x+3)", "(x-2)/(x+1)^2", "(x+2)/(x+3)(x-1)", "(2x-4)/(x^2+x-2)", "(x-2)/(x^2-4x)", "(2x(x+2))/(x-1)(x-4)", "4x^2/(x^2-2x-3)", "(2x^2+2x-4)/(x^2+x)", "(x^2+3x)/(x^2-x-6)", "(5x^2+5)/(x^2+4x+4)", "(x^3-x^2)/(x^3-3x-2)", "" };
        interx = new string[] { "1", "4/3", "no", "2", "no", "-2", "-2 y 1,", "1", "-6 y 1", "-2 y 3", "no", "1", "-3", "1/2", "2", "-2", "2", "2", "-2 y 0", "0", "-2 y 1", "-3 y 0", "no", "0 y 1", "" };
        intery = new string[] { "-2", "4/7", "2", "2", "-1", "-3/4", "2/3", "1", "2", "no", "-2", "no", "2", "1/3", "-2", "-2/3", "2", "no", "0", "0", "no", "0", "5/4", "0", "" };
        asix = new string[] { "4", "-3", "0", "0", "0", "0", "1", "1", "2", "1", "3", "0", "-1/3", "-1", "0", "0", "0", "0", "2", "4", "2", "1", "5", "1", "" };
        asiy = new string[] { "-2", "-7", "3", "-1 y 4", "-1 y 6", "-4 y 2", "-1 y 3", "-1", "-3 y 2", "-3 y 0", "-1 y 3", "0 y 3", "1/2", "-3/2", "-1", "-3 y 1", "-2 y 1", "0 y 4", "1 y 4", "-1 y 3", "-1 y 0", "-2 y 3", "-2", "-1 y 2", "" };
        funcion.text = funcs[index];
        inp2.interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        //tiempo
        if (timeLeft >= 0)
        {
            timeLeft -= Time.deltaTime;
            timeToPlay -= Time.deltaTime;
            tiempo.text = "Tiempo: " + minutos + ":" + Mathf.Round(timeLeft);
            punto.text = "Puntos: " + correct;
            if (timeLeft < 0 && minutos > 0)
            {
                timeLeft = 59.0f;
                minutos--;
            }
        }
        else
        {
            inp.interactable = false;
            inp2.interactable = false;
            inp3.interactable = false;
            inp4.interactable = false;
            resultado.color = new Color(0, 0, 0, 1);
            grafica.color = new Color(0, 0, 0, 0);
            if (correct >= 48)
            {
                resultado.text = "Felicidades! Nivel Superado!";
            }
            else
            {
                resultado.text = "Nivel fallido :( Intenta de nuevo!";
            }
        }

        //respuestas
        if(inp.text == interx[index])
        {
            inp.image.color = new Color(0, 0, 0, 0);
            correct++;
            inp.text = inp.text + ".";
            inp.interactable = false;
            act = true;
            taskOnAnimar();
        }

        if (inp2.text == intery[index])
        {
            inp2.image.color = new Color(0, 0, 0, 0);
            correct++;
            inp2.text = inp2.text + ".";
            inp2.interactable = false;
            act2 = true;
            taskOnAnimar();
        }

        if (inp3.text == asix[index])
        {
            inp3.image.color = new Color(0, 0, 0, 0);
            correct++;
            inp3.text = inp3.text + ".";
            inp3.interactable = false;
            act3 = true;
            taskOnAnimar();
        }

        if (inp4.text == asiy[index])
        {
            inp4.image.color = new Color(0, 0, 0, 0);
            correct++;
            inp4.text = inp4.text + ".";
            inp4.interactable = false;
            act4 = true;
            taskOnAnimar();
        }

        //cambio de index
        if(act == true && act2 == true && act3 == true && act4 == true)
        {
            index++;
            act = false;
            act2 = false;
            act3 = false;
            act4 = false;
            inp.interactable = true;
            inp2.interactable = true;
            inp3.interactable = true;
            inp4.interactable = true;
            inp.image.color = new Color(255, 255, 255, 1);
            inp2.image.color = new Color(255, 255, 255, 1);
            inp3.image.color = new Color(255, 255, 255, 1);
            inp4.image.color = new Color(255, 255, 255, 1);
            inp.text = "";
            inp2.text = "";
            inp3.text = "";
            inp4.text = "";
        }

        //en caso de que se acaben los problemas

        if (index >= 24)
        {
            timeLeft = 0;
            minutos = 0;
        }

        grafica.sprite = grafs[index];
        funcion.text = funcs[index];
        num.text = (index+1).ToString();
        skip.onClick.AddListener(taskOnSkip);
        secreto = true;

        //animaciones

        if(si2 == true)
        {
            si.color = new Color(255, 255, 255, 1);
        }
        else
        {
            si.color = new Color(0, 0, 0, 0);
        }

        if (no2 == true)
        {
            no.color = new Color(255, 255, 255, 1);
        }
        else
        {
            no.color = new Color(0, 0, 0, 0);
        }

        if (timeToPlay >= 0)
        {
            grafica.color = new Color(0, 0, 0, 0);
            inp.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            inp2.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            inp3.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            inp4.GetComponent<Image>().color = new Color(0, 0, 0, 0);
        }
        else
        {
            si2 = false;
            grafica.color = new Color(255, 255, 255, 1);
            inp.GetComponent<Image>().color = new Color(255, 255, 255, 1);
            inp2.GetComponent<Image>().color = new Color(255, 255, 255, 1);
            inp3.GetComponent<Image>().color = new Color(255, 255, 255, 1);
            inp4.GetComponent<Image>().color = new Color(255, 255, 255, 1);
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

    void taskOnSkip()
    {
        if (act == true || act2 == true || act3 == true || act4 == true || secreto == true)
        {
            index++;
            act = false;
            act2 = false;
            act3 = false;
            act4 = false;
            secreto = false;
            inp.interactable = true;
            inp2.interactable = true;
            inp3.interactable = true;
            inp4.interactable = true;
            inp.image.color = new Color(255, 255, 255, 1);
            inp2.image.color = new Color(255, 255, 255, 1);
            inp3.image.color = new Color(255, 255, 255, 1);
            inp4.image.color = new Color(255, 255, 255, 1);
            inp.text = "";
            inp2.text = "";
            inp3.text = "";
            inp4.text = "";
        }
    }

    void taskOnAnimar()
    {
        timeToPlay = 1f;
        si2 = true;
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
