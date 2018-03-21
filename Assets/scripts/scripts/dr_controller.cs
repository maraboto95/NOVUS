using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class dr_controller : MonoBehaviour
{

    public Text opciond1, opciond2, opciond3, opciond4, opcionr1, opcionr2, opcionr3, opcionr4, correcto, error, completar, textButton, textButton2;
    public Image grafica;
    public Button d1, d2, d3, d4, r1, r2, r3, r4, regresar;
    public Sprite s1, s2, s3, s4, s5, s6;
    private Sprite[] ss;
    private string[] td1, td2, td3, td4, tr1, tr2, tr3, tr4;
    private int index, correct, noCorrect, control, dominio, rango, controlD, controlR;
    private bool readyD, readyR, clicked;
    private float timeLeft, timeToChange;


    // Use this for initialization
    void Start()
    {
        index = 0;
        clicked = false;
        correct = 0;
        noCorrect = 0;
        dominio = 0;
        rango = 0;
        control = 1;
        controlD = 1;
        controlR = 1;
        timeLeft = 0f;
        timeToChange = 2f;
        correcto.text = "Correcto: " + correct;
        error.text = "Errores " + noCorrect;
        ss = new Sprite[] { s1, s2, s3, s4, s5, s6 };
        td1 = new string[] { "(-inf, inf)", "(-inf, inf)", "(-inf, inf)", "(-inf, inf)", "5", "(-inf, inf)" };
        td2 = new string[] { "(-2, 2)", "(-2, 2)", "(-2, 2)", "(-2, 2)", "7", "(-2, 2)" };
        td3 = new string[] { "[-2, 2]", "[-2, 2]", "[-2, 2]", "[-2, 2]", "1", "[-2, 2]" };
        td4 = new string[] { "(-2, inf)", "(-2, inf)", "(-2, inf)", "(-2, inf)", "99", "(-2, inf)" };
        tr1 = new string[] { "[-4.5, 5.2]", "[-4.5, 5.2]", "[-4.5, 5.2]", "[-4.5, 5.2]", "5", "[-4.5, 5.2]" };
        tr2 = new string[] { "[-5, 5]", "[-5, 5]", "[-5, 5]", "[-5, 5]", "7", "[-5, 5]" };
        tr3 = new string[] { "(-5, inf)", "(-5, inf)", "(-5, inf)", "(-5, inf)", "1", "(-5, inf)" };
        tr4 = new string[] { "(-inf, inf)", "(-inf, inf)", "(-inf, inf)", "(-inf, inf)", "99", "(-inf, inf)" };
        grafica.sprite = ss[index];
        opciond1.text = td1[index];
        opciond2.text = td2[index];
        opciond3.text = td3[index];
        opciond4.text = td4[index];
        opcionr1.text = tr1[index];
        opcionr2.text = tr2[index];
        opcionr3.text = tr3[index];
        opcionr4.text = tr4[index];
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft += Time.deltaTime;
        d1.onClick.AddListener(respuestaD1);
        d1.onClick.AddListener(taskOnDominio);
        d2.onClick.AddListener(respuestaD2);
        d2.onClick.AddListener(taskOnDominio);
        d3.onClick.AddListener(respuestaD3);
        d3.onClick.AddListener(taskOnDominio);
        d4.onClick.AddListener(respuestaD4);
        d4.onClick.AddListener(taskOnDominio);
        r1.onClick.AddListener(respuestaR1);
        r1.onClick.AddListener(taskOnRango);
        r2.onClick.AddListener(respuestaR2);
        r2.onClick.AddListener(taskOnRango);
        r3.onClick.AddListener(respuestaR3);
        r3.onClick.AddListener(taskOnRango);
        r4.onClick.AddListener(respuestaR4);
        r4.onClick.AddListener(taskOnRango);
        correcto.text = "Correcto: " + correct;
        error.text = "Errores " + noCorrect;
        grafica.sprite = ss[index];
        opciond1.text = td1[index];
        opciond2.text = td2[index];
        opciond3.text = td3[index];
        opciond4.text = td4[index];
        opcionr1.text = tr1[index];
        opcionr2.text = tr2[index];
        opcionr3.text = tr3[index];
        opcionr4.text = tr4[index];

        if(correct+noCorrect >= 12)
        {
            timeToChange -= Time.deltaTime;

            if (timeToChange <= 0)
            {
                taskOnRegresar();
            }

            if (correct > noCorrect)
            {
                completar.text = "Felicidades! Nivel Completado!";
                PlayerPrefs.SetInt("domran", 1);
            }
            else
            {
                completar.text = "Nivel Fallido :( Intenta de nuevo";
            }
        }

        if(Mathf.Round(timeLeft) == 1)
        {
            readyR = false;
            readyD = false;
        }

        if (index == control)
        {
            control++;
        }

        if (dominio == controlD)
        {
            controlD++;
        }

        if (rango == controlR)
        {
            controlR++;
        }

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

    void taskOnDominio()
    {
        if (dominio < controlD)
        {
            dominio++;
        }

        if (dominio > rango)
        {
            d1.interactable = false;
            d2.interactable = false;
            d3.interactable = false;
            d4.interactable = false;
            readyD = true;
        }

        if (dominio == rango)
        {
            d1.interactable = true;
            d2.interactable = true;
            d3.interactable = true;
            d4.interactable = true;
            r1.interactable = true;
            r2.interactable = true;
            r3.interactable = true;
            r4.interactable = true;
            readyD = true;
            timeLeft = 0f;
        }

        if (index < control && index < 5 && rango >= 1 && dominio == rango)
        {
            index++;
        }
    }

    void taskOnRango()
    {
        if (rango < controlR)
        {
            rango++;
        }

        if (dominio < rango)
        {
            r1.interactable = false;
            r2.interactable = false;
            r3.interactable = false;
            r4.interactable = false;
            readyR = true;
        }

        if (dominio == rango)
        {
            r1.interactable = true;
            r2.interactable = true;
            r3.interactable = true;
            r4.interactable = true;
            d1.interactable = true;
            d2.interactable = true;
            d3.interactable = true;
            d4.interactable = true;
            readyR = true;
            timeLeft = 0f;
        }

        if (index < control && index < 5 && dominio >= 1 && dominio == rango)
        {
            index++;
        }
    }

    void respuestaD1()
    {
        if (readyD == false)
        {
            switch (dominio)
            {
                case 0:
                    correct++;
                    break;

                case 1:
                    noCorrect++;
                    break;

                case 2:
                    noCorrect++;
                    break;

                case 3:
                    correct++;
                    break;

                case 4:
                    noCorrect++;
                    break;

                case 5:
                    noCorrect++;
                    break;
            }
        }
    }

    void respuestaR1()
    {
        if (readyR == false)
        {
            switch (rango)
            {
                case 0:
                    correct++;
                    break;

                case 1:
                    noCorrect++;
                    break;

                case 2:
                    noCorrect++;
                    break;

                case 3:
                    correct++;
                    break;

                case 4:
                    noCorrect++;
                    break;

                case 5:
                    noCorrect++;
                    break;
            }
        }
    }

    void respuestaD2()
    {
        if (readyD == false)
        {
            switch (dominio)
            {
                case 0:
                    noCorrect++;
                    break;

                case 1:
                    noCorrect++;
                    break;

                case 2:
                    correct++;
                    break;

                case 3:
                    noCorrect++;
                    break;

                case 4:
                    noCorrect++;
                    break;

                case 5:
                    noCorrect++;
                    break;
            }
        }
    }

    void respuestaD3()
    {
        if (readyD == false)
        {
            switch (dominio)
            {
                case 0:
                    noCorrect++;
                    break;

                case 1:
                    correct++;
                    break;

                case 2:
                    noCorrect++;
                    break;

                case 3:
                    noCorrect++;
                    break;

                case 4:
                    correct++;
                    break;

                case 5:
                    noCorrect++;
                    break;
            }
        }
    }

    void respuestaD4()
    {
        if (readyD == false)
        {
            switch (dominio)
            {
                case 0:
                    noCorrect++;
                    break;

                case 1:
                    noCorrect++;
                    break;

                case 2:
                    noCorrect++;
                    break;

                case 3:
                    noCorrect++;
                    break;

                case 4:
                    noCorrect++;
                    break;

                case 5:
                    correct++;
                    break;
            }
        }
    }

    void respuestaR2()
    {
        if (readyR == false)
        {
            switch (rango)
            {
                case 0:
                    noCorrect++;
                    break;

                case 1:
                    noCorrect++;
                    break;

                case 2:
                    correct++;
                    break;

                case 3:
                    noCorrect++;
                    break;

                case 4:
                    noCorrect++;
                    break;

                case 5:
                    noCorrect++;
                    break;
            }
        }
    }

    void respuestaR3()
    {
        if (readyR == false)
        {
            switch (rango)
            {
                case 0:
                    noCorrect++;
                    break;

                case 1:
                    correct++;
                    break;

                case 2:
                    noCorrect++;
                    break;

                case 3:
                    noCorrect++;
                    break;

                case 4:
                    correct++;
                    break;

                case 5:
                    noCorrect++;
                    break;
            }
        }
    }

    void respuestaR4()
    {
        if (readyR == false)
        {
            switch (rango)
            {
                case 0:
                    noCorrect++;
                    break;

                case 1:
                    noCorrect++;
                    break;

                case 2:
                    noCorrect++;
                    break;

                case 3:
                    noCorrect++;
                    break;

                case 4:
                    noCorrect++;
                    break;

                case 5:
                    correct++;
                    break;
            }
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
