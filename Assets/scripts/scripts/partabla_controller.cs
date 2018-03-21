using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class partabla_controller : MonoBehaviour {

    public Text e1, e2, e3, e4, e5, n1, n2, n3, n4, n5, r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, puntos;
    public InputField inp1, inp2, inp3, inp4, inp5, inp6, inp7, inp8, inp9, inp10, inp11, inp12, inp13, inp14, inp15;
    public Button saltar, regresar;
    private string[] elementos, cargas;
    private int[] protones, neutrones, electrones;
    private int index, salto, punto;
    private bool b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15, listo, clicked;
    public float timeToChange;

	// Use this for initialization
	void Start () {
        index = 0;
        timeToChange = 2f;
        clicked = false;
        salto = 5;
        punto = 0;
        puntos.text = "Puntos: " + punto.ToString();
        elementos = new string[] { "Cl", "Ca+2", "N", "S-2", "Co", "", "", "", "", "" };
        protones = new int[] { 17, 20, 7, 16, 27, 0, 0, 0, 0, 0 };
        neutrones = new int[] { 19, 20, 7, 16, 32, 0, 0, 0, 0, 0 };
        electrones = new int[] { 17, 18, 7, 18, 27, 0, 0, 0, 0, 0 };
        cargas = new string[] { "neutra", "cation", "neutra", "anion", "neutra", "", "", "", "", "" };
        e1.text = elementos[index];
        e2.text = elementos[index + 1];
        e3.text = elementos[index + 2];
        e4.text = elementos[index + 3];
        e5.text = elementos[index + 4];
        n1.text = neutrones[index].ToString();
        n2.text = neutrones[index + 1].ToString();
        n3.text = neutrones[index + 2].ToString();
        n4.text = neutrones[index + 3].ToString();
        n5.text = neutrones[index + 4].ToString();
        r1.text = protones[index].ToString();
        r1.color = new Color(0, 0, 0, 0);
        r2.text = protones[index + 1].ToString();
        r2.color = new Color(0, 0, 0, 0);
        r3.text = protones[index + 2].ToString();
        r3.color = new Color(0, 0, 0, 0);
        r4.text = protones[index + 3].ToString();
        r4.color = new Color(0, 0, 0, 0);
        r5.text = protones[index + 4].ToString();
        r5.color = new Color(0, 0, 0, 0);
        r6.text = electrones[index].ToString();
        r6.color = new Color(0, 0, 0, 0);
        r7.text = electrones[index + 1].ToString();
        r7.color = new Color(0, 0, 0, 0);
        r8.text = electrones[index + 2].ToString();
        r8.color = new Color(0, 0, 0, 0);
        r9.text = electrones[index + 3].ToString();
        r9.color = new Color(0, 0, 0, 0);
        r10.text = electrones[index + 4].ToString();
        r10.color = new Color(0, 0, 0, 0);
        r11.text = cargas[index];
        r11.color = new Color(0, 0, 0, 0);
        r12.text = cargas[index + 1];
        r12.color = new Color(0, 0, 0, 0);
        r13.text = cargas[index + 2];
        r13.color = new Color(0, 0, 0, 0);
        r14.text = cargas[index + 3];
        r14.color = new Color(0, 0, 0, 0);
        r15.text = cargas[index + 4];
        r15.color = new Color(0, 0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (inp1.text.Equals(r1.text) && b1 == false){
            punto++;
            b1 = true;
            inp1.image.color = new Color(0, 0, 0, 0);
            r1.color = new Color(0, 0, 0, 1);
            inp1.text = "";
            inp1.interactable = false;
        }

        if (inp2.text.Equals(r2.text) && b2 == false)
        {
            punto++;
            b2 = true;
            inp2.image.color = new Color(0, 0, 0, 0);
            r2.color = new Color(0, 0, 0, 1);
            inp2.text = "";
            inp2.interactable = false;
        }

        if (inp3.text.Equals(r3.text) && b3 == false)
        {
            punto++;
            b3 = true;
            inp3.image.color = new Color(0, 0, 0, 0);
            r3.color = new Color(0, 0, 0, 1);
            inp3.text = "";
            inp3.interactable = false;
        }

        if (inp4.text.Equals(r4.text) && b4 == false)
        {
            punto++;
            b4 = true;
            inp4.image.color = new Color(0, 0, 0, 0);
            r4.color = new Color(0, 0, 0, 1);
            inp4.text = "";
            inp4.interactable = false;
        }

        if (inp5.text.Equals(r5.text) && b5 == false)
        {
            punto++;
            b5 = true;
            inp5.image.color = new Color(0, 0, 0, 0);
            r5.color = new Color(0, 0, 0, 1);
            inp5.text = "";
            inp5.interactable = false;
        }

        if (inp6.text.Equals(r6.text) && b6 == false)
        {
            punto++;
            b6 = true;
            inp6.image.color = new Color(0, 0, 0, 0);
            r6.color = new Color(0, 0, 0, 1);
            inp6.text = "";
            inp6.interactable = false;
        }

        if (inp7.text.Equals(r7.text) && b7 == false)
        {
            punto++;
            b7 = true;
            inp7.image.color = new Color(0, 0, 0, 0);
            r7.color = new Color(0, 0, 0, 1);
            inp7.text = "";
            inp7.interactable = false;
        }

        if (inp8.text.Equals(r8.text) && b8 == false)
        {
            punto++;
            b8 = true;
            inp8.image.color = new Color(0, 0, 0, 0);
            r8.color = new Color(0, 0, 0, 1);
            inp8.text = "";
            inp8.interactable = false;
        }

        if (inp9.text.Equals(r9.text) && b9 == false)
        {
            punto++;
            b9 = true;
            inp9.image.color = new Color(0, 0, 0, 0);
            r9.color = new Color(0, 0, 0, 1);
            inp9.text = "";
            inp9.interactable = false;
        }

        if (inp10.text.Equals(r10.text) && b10 == false)
        {
            punto++;
            b10 = true;
            inp10.image.color = new Color(0, 0, 0, 0);
            r10.color = new Color(0, 0, 0, 1);
            inp10.text = "";
            inp10.interactable = false;
        }

        if (inp11.text.Equals(r11.text) && b11 == false)
        {
            punto++;
            b11 = true;
            inp11.image.color = new Color(0, 0, 0, 0);
            r11.color = new Color(0, 0, 0, 1);
            inp11.text = "";
            inp11.interactable = false;
        }

        if (inp12.text.Equals(r12.text) && b12 == false)
        {
            punto++;
            b12 = true;
            inp12.image.color = new Color(0, 0, 0, 0);
            r12.color = new Color(0, 0, 0, 1);
            inp12.text = "";
            inp12.interactable = false;
        }

        if (inp13.text.Equals(r13.text) && b13 == false)
        {
            punto++;
            b13 = true;
            inp13.image.color = new Color(0, 0, 0, 0);
            r13.color = new Color(0, 0, 0, 1);
            inp13.text = "";
            inp13.interactable = false;
        }

        if (inp14.text.Equals(r14.text) && b14 == false)
        {
            punto++;
            b14 = true;
            inp14.image.color = new Color(0, 0, 0, 0);
            r14.color = new Color(0, 0, 0, 1);
            inp14.text = "";
            inp14.interactable = false;
        }

        if (inp15.text.Equals(r15.text) && b15 == false)
        {
            punto++;
            b15 = true;
            inp15.image.color = new Color(0, 0, 0, 0);
            r15.color = new Color(0, 0, 0, 1);
            inp15.text = "";
            inp15.interactable = false;
        }

        puntos.text = "Puntos: " + punto.ToString();
        saltar.onClick.AddListener(taskOnClick);
        e1.text = elementos[index];
        e2.text = elementos[index + 1];
        e3.text = elementos[index + 2];
        e4.text = elementos[index + 3];
        e5.text = elementos[index + 4];
        n1.text = neutrones[index].ToString();
        n2.text = neutrones[index + 1].ToString();
        n3.text = neutrones[index + 2].ToString();
        n4.text = neutrones[index + 3].ToString();
        n5.text = neutrones[index + 4].ToString();
        r1.text = protones[index].ToString();
        r2.text = protones[index + 1].ToString();
        r3.text = protones[index + 2].ToString();
        r4.text = protones[index + 3].ToString();
        r5.text = protones[index + 4].ToString();
        r6.text = electrones[index].ToString();
        r7.text = electrones[index + 1].ToString();
        r8.text = electrones[index + 2].ToString();
        r9.text = electrones[index + 3].ToString();
        r10.text = electrones[index + 4].ToString();
        r11.text = cargas[index];
        r12.text = cargas[index + 1];
        r13.text = cargas[index + 2];
        r14.text = cargas[index + 3];
        r15.text = cargas[index + 4];
        if(b1 == true && b2==true && b3==true && b4==true && b5==true && b6==true && b7==true && b8==true && b9==true && b10==true && b11==true && b12==true && b13==true && b14==true && b15 == true)
        {
            taskOnClick();
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

    void taskOnClick()
    {
        if (listo == false)
        {
            listo = true;
            index = index + salto;
            punto = punto - 5;
        }
        r1.color = new Color(0, 0, 0, 0);
        r2.color = new Color(0, 0, 0, 0);
        r3.color = new Color(0, 0, 0, 0);
        r4.color = new Color(0, 0, 0, 0);
        r5.color = new Color(0, 0, 0, 0);
        r6.color = new Color(0, 0, 0, 0);
        r7.color = new Color(0, 0, 0, 0);
        r8.color = new Color(0, 0, 0, 0);
        r9.color = new Color(0, 0, 0, 0);
        r10.color = new Color(0, 0, 0, 0);
        r11.color = new Color(0, 0, 0, 0);
        r12.color = new Color(0, 0, 0, 0);
        r13.color = new Color(0, 0, 0, 0);
        r14.color = new Color(0, 0, 0, 0);
        r15.color = new Color(0, 0, 0, 0);
        inp1.image.color = new Color(255, 255, 255, 1);
        inp1.interactable = true;
        inp2.image.color = new Color(255, 255, 255, 1);
        inp2.interactable = true;
        inp3.image.color = new Color(255, 255, 255, 1);
        inp3.interactable = true;
        inp4.image.color = new Color(255, 255, 255, 1);
        inp4.interactable = true;
        inp5.image.color = new Color(255, 255, 255, 1);
        inp5.interactable = true;
        inp6.image.color = new Color(255, 255, 255, 1);
        inp6.interactable = true;
        inp7.image.color = new Color(255, 255, 255, 1);
        inp7.interactable = true;
        inp8.image.color = new Color(255, 255, 255, 1);
        inp8.interactable = true;
        inp9.image.color = new Color(255, 255, 255, 1);
        inp9.interactable = true;
        inp10.image.color = new Color(255, 255, 255, 1);
        inp10.interactable = true;
        inp11.image.color = new Color(255, 255, 255, 1);
        inp11.interactable = true;
        inp12.image.color = new Color(255, 255, 255, 1);
        inp12.interactable = true;
        inp13.image.color = new Color(255, 255, 255, 1);
        inp13.interactable = true;
        inp14.image.color = new Color(255, 255, 255, 1);
        inp14.interactable = true;
        inp15.image.color = new Color(255, 255, 255, 1);
        inp15.interactable = true;
        b1 = false;
        b2 = false;
        b3 = false;
        b4 = false;
        b5 = false;
        b6 = false;
        b7 = false;
        b8 = false;
        b9 = false;
        b10 = false;
        b11 = false;
        b12 = false;
        b13 = false;
        b14 = false;
        b15 = false;
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
