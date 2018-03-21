using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class particontroller : MonoBehaviour {

    public Text pregunta, correct, noCorrect, top1, top2, top3, top4, tinp1, tinp2, tinp3, talidar, talidar2, tresp, textButton, completar, textButton2;
    public Button op1, op2, op3, op4, validar, validar2, regresar;
    private string[] preguntas, smop1, smop2, smop3, smop4;
    private int index, correctint, noco, control, seccion;
    private float timeLeft, timeToPlay, timeToChange;
    private bool si2, no2, clicked;
    public InputField atomic, elemento, masa, resp;
    public Image tabla;
    public SpriteRenderer si, no;

	// Use this for initialization
	void Start () {
        index = 0;
        clicked = false;
        correctint = 0;
        noco = 0;
        seccion = 0;
        control = 1;
        timeLeft = 0f;
        timeToPlay = -1f;
        timeToChange = 2;
        correct.text = "Correcto: " + correctint;
        noCorrect.text = "Errores: " + noco;
        preguntas = new string[] { "Un átomo tiene 35 electrones, 35 protones y 45 neutrones; su número de masa es:", "Un átomo tiene 15 electrones, 15 protones y 16 neutrones; su número atómico es:", "Un átomo tiene el número atómico 33 y número de masa 75; el número de neutrones que tiene es:", "Un átomo de número atómico 16 y número de masa 32 ganó dos electrones; su número de protones es:", "Un átomo de número atómico 19 y número de masa 39 perdió un electrón; su número de electrones es:", "El número de electrones, protones y neutrones en el 36Cl es:", "El isótopo del magnesio con número de masa 24:", "El isótopo del vanadio que contiene 28 neutrones y número atómico 23:", "El isótopo del azufre  que contiene 16 protones, 16 electrones y 16 neutrones:", "El isótopo del bromo  que contiene 35 protones y 45 neutrones:", "¿Son isótopos del mismo elemento los átomos A y C?", "¿Son isótopos del mismo elemento los átomos B y C?", "¿Cuál es el número de masa del átomo B?", "¿Cuál es el número de masa del átomo C?", "" };
        smop1 = new string[] { "70", "15", "33", "18", "20", "17p+, 17e-, 36n°", "", "", "", "", "", "", "", "", "" };
        smop2 = new string[] { "35", "30", "75", "16", "40", "17p+, 17e-, 19n°", "", "", "", "", "", "", "", "", "" };
        smop3 = new string[] { "80", "31", "42", "32", "19", "17p+, 17e-, 17n°", "", "", "", "", "", "", "", "", "" };
        smop4 = new string[] { "115", "16", "108", "34", "18", "19p+, 19e-, 36n°", "", "", "", "", "", "", "", "", "" };
        pregunta.text = preguntas[index];
        top1.text = smop1[index];
        top2.text = smop2[index];
        top3.text = smop3[index];
        top4.text = smop4[index];
        atomic.interactable = false;
        elemento.interactable = false;
        masa.interactable = false;
        validar.interactable = false;
        validar2.interactable = false;
        resp.interactable = false;
        atomic.image.color = new Color(0, 0, 0, 0);
        elemento.image.color = new Color(0, 0, 0, 0);
        masa.image.color = new Color(0, 0, 0, 0);
        validar.image.color = new Color(0, 0, 0, 0);
        validar2.image.color = new Color(0, 0, 0, 0);
        resp.image.color = new Color(0, 0, 0, 0);
        tinp1.color = new Color(0, 0, 0, 0);
        tinp2.color = new Color(0, 0, 0, 0);
        tinp3.color = new Color(0, 0, 0, 0);
        tresp.color = new Color(0, 0, 0, 0);
        tabla.color = new Color(0, 0, 0, 0);
        talidar.text = "";
        talidar2.text = "";
        completar.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        timeLeft += Time.deltaTime;
        timeToPlay -= Time.deltaTime;
        op1.onClick.AddListener(respuesta1);
        op2.onClick.AddListener(respuesta2);
        op3.onClick.AddListener(respuesta3);
        op4.onClick.AddListener(respuesta4);
        validar.onClick.AddListener(taskOnValidar);
        validar2.onClick.AddListener(taskOnValidar2);
        correct.text = "Correcto: " + correctint;
        noCorrect.text = "Errores: " + noco;
        pregunta.text = preguntas[index];
        top1.text = smop1[index];
        top2.text = smop2[index];
        top3.text = smop3[index];
        top4.text = smop4[index];

        if (index == control)
        {
            control++;
        }

        if(control > 6 && control < 11)
        {
            seccion = 1;
            op1.interactable = false;
            op2.interactable = false;
            op3.interactable = false;
            op4.interactable = false;
            op1.image.color = new Color(0, 0, 0, 0);
            op2.image.color = new Color(0, 0, 0, 0);
            op3.image.color = new Color(0, 0, 0, 0);
            op4.image.color = new Color(0, 0, 0, 0);
            atomic.interactable = true;
            elemento.interactable = true;
            masa.interactable = true;
            validar.interactable = true;
            atomic.image.color = new Color(255, 255, 255, 1);
            elemento.image.color = new Color(255, 255, 255, 1);
            masa.image.color = new Color(255, 255, 255, 1);
            validar.image.color = new Color(255, 255, 255, 1);
            tinp1.color = new Color(0, 0, 0, 1);
            tinp2.color = new Color(0, 0, 0, 1);
            tinp3.color = new Color(0, 0, 0, 1);
            talidar.text = "Validar";
        }

        if(control > 10 && control < 15)
        {
            seccion = 2;
            atomic.interactable = false;
            elemento.interactable = false;
            masa.interactable = false;
            validar.interactable = false;
            atomic.image.color = new Color(0, 0, 0, 0);
            elemento.image.color = new Color(0, 0, 0, 0);
            masa.image.color = new Color(0, 0, 0, 0);
            validar.image.color = new Color(0, 0, 0, 0);
            tinp1.color = new Color(0, 0, 0, 0);
            tinp2.color = new Color(0, 0, 0, 0);
            tinp3.color = new Color(0, 0, 0, 0);
            talidar.text = "";
            tabla.color = new Color(255, 255, 255, 1);
            resp.interactable = true;
            resp.image.color = new Color(255, 255, 255, 1);
            tresp.color = new Color(0, 0, 0, 1);
            validar2.interactable = true;
            validar2.image.color = new Color(255, 255, 255, 1);
            talidar2.text = "Validar";
        }

        if(control > 14)
        {
            tabla.color = new Color(0, 0, 0, 0);
            resp.interactable = false;
            resp.image.color = new Color(0, 0, 0, 0);
            tresp.color = new Color(0, 0, 0, 0);
            validar2.interactable = false;
            validar2.image.color = new Color(0, 0, 0, 0);
            talidar2.text = "";
            if (correctint > 8)
            {
                completar.text = "Felicidades! Nivel Completado!";
                PlayerPrefs.SetInt("particulas", 1);
                timeToChange -= Time.deltaTime;
                if (timeToChange <= 0)
                {
                    SceneManager.LoadScene("test_scene");
                }
            }
            else
            {
                completar.text = "Nivel Fallido :( ¿Intentar de nuevo?";
                timeToChange -= Time.deltaTime;
                if (timeToChange <= 0)
                {
                    SceneManager.LoadScene("test_scene");
                }
            }
        }

        //animaciones

        if (si2 == true)
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
            
        }
        else
        {
            si2 = false;
            no2 = false;
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

    void respuesta1()
    {
        if(index < control && index < 6)
        {
            switch (control)
            {
                case 1:
                    noco++;
                    taskOnNo();
                    break;

                case 2:
                    correctint++;
                    taskOnSi();
                    break;

                case 3:
                    noco++;
                    taskOnNo();
                    break;

                case 4:
                    correctint++;
                    taskOnSi();
                    break;

                case 5:
                    noco++;
                    taskOnNo();
                    break;

                case 6:
                    noco++;
                    taskOnNo();
                    break;
            }

            index++;
        }
    }

    void respuesta2()
    {
        if (index < control && index < 6)
        {
            switch (control)
            {
                case 1:
                    noco++;
                    taskOnNo();
                    break;

                case 2:
                    noco++;
                    taskOnNo();
                    break;

                case 3:
                    noco++;
                    taskOnNo();
                    break;

                case 4:
                    noco++;
                    taskOnNo();
                    break;

                case 5:
                    noco++;
                    taskOnNo();
                    break;

                case 6:
                    correctint++;
                    taskOnSi();
                    break;
            }

            index++;
        }
    }

    void respuesta3()
    {
        if (index < control && index < 6)
        {
            switch (control)
            {
                case 1:
                    correctint++;
                    taskOnSi();
                    break;

                case 2:
                    noco++;
                    taskOnNo();
                    break;

                case 3:
                    correctint++;
                    taskOnSi();
                    break;

                case 4:
                    noco++;
                    taskOnNo();
                    break;

                case 5:
                    noco++;
                    taskOnNo();
                    break;

                case 6:
                    noco++;
                    taskOnNo();
                    break;
            }

            index++;
        }
    }

    void respuesta4()
    {
        if (index < control && index < 6)
        {
            switch (control)
            {
                case 1:
                    noco++;
                    taskOnNo();
                    break;

                case 2:
                    noco++;
                    taskOnNo();
                    break;

                case 3:
                    noco++;
                    taskOnNo();
                    break;

                case 4:
                    noco++;
                    taskOnNo();
                    break;

                case 5:
                    correctint++;
                    taskOnSi();
                    break;

                case 6:
                    noco++;
                    taskOnNo();
                    break;
            }

            index++;
        }
    }

    void taskOnValidar()
    {
        if(index < control && index < 10)
        {
            switch (control)
            {
                case 7:
                    if(atomic.text == "12" && elemento.text.ToLower() == "mg" && masa.text == "24")
                    {
                        correctint++;
                        taskOnSi();
                    }
                    else
                    {
                        noco++;
                        taskOnNo();
                    }

                    atomic.text = "";
                    elemento.text = "";
                    masa.text = "";
                    break;

                case 8:
                    if (atomic.text == "23" && elemento.text.ToLower() == "v" && masa.text == "51")
                    {
                        correctint++;
                        taskOnSi();
                    }
                    else
                    {
                        noco++;
                        taskOnNo();
                    }

                    atomic.text = "";
                    elemento.text = "";
                    masa.text = "";
                    break;

                case 9:
                    if (atomic.text == "16" && elemento.text.ToLower() == "s" && masa.text == "32")
                    {
                        correctint++;
                        taskOnSi();
                    }
                    else
                    {
                        noco++;
                        taskOnNo();
                    }

                    atomic.text = "";
                    elemento.text = "";
                    masa.text = "";
                    break;

                case 10:
                    if (atomic.text == "35" && elemento.text.ToLower() == "br" && masa.text == "80")
                    {
                        correctint++;
                        taskOnSi();
                    }
                    else
                    {
                        noco++;
                        taskOnNo();
                    }

                    atomic.text = "";
                    elemento.text = "";
                    masa.text = "";
                    break;
            }

            index++;
        }
    }

    void taskOnValidar2()
    {
        if (index < control && index < 14)
        {
            switch (control)
            {
                case 11:
                    if (resp.text.ToLower() == "no")
                    {
                        correctint++;
                        taskOnSi();
                    }
                    else
                    {
                        noco++;
                        taskOnNo();
                    }

                    resp.text = "";
                    break;

                case 12:
                    if (resp.text.ToLower() == "si")
                    {
                        correctint++;
                        taskOnSi();
                    }
                    else
                    {
                        noco++;
                        taskOnNo();
                    }

                    resp.text = "";
                    break;

                case 13:
                    if (resp.text.ToLower() == "21")
                    {
                        correctint++;
                        taskOnSi();
                    }
                    else
                    {
                        noco++;
                        taskOnNo();
                    }

                    resp.text = "";
                    break;

                case 14:
                    if (resp.text.ToLower() == "22")
                    {
                        correctint++;
                        taskOnSi();
                    }
                    else
                    {
                        noco++;
                        taskOnNo();
                    }

                    resp.text = "";
                    break;
            }

            index++;
        }
    }

    void taskOnSi()
    {
        timeToPlay = 1f;
        si2 = true;
    }

    void taskOnNo()
    {
        timeToPlay = 1f;
        no2 = true;
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
