using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OpcionesScript_graficas : MonoBehaviour {

    public static OpcionesScript_graficas script;

    public Sprite u1, u2, u3, u4, d1, d2, d3, d4, t1, t2, t3, t4;
    Sprite[,] graficas = new Sprite[3, 4];

    public int elegida;
    public int correcta;

    public Button op1, op2, op3;

    bool clickable = true;


    void Awake()
    {
        script = this;

        llenaArray();

        mandarCambio();


    }//awake


    void llenaArray()
    {
        graficas[0, 0] = u1;
        graficas[0, 1] = u2;
        graficas[0, 2] = u3;
        graficas[0, 3] = u4;
        graficas[1, 0] = d1;
        graficas[1, 1] = d2;
        graficas[1, 2] = d3;
        graficas[1, 3] = d4;
        graficas[2, 0] = t1;
        graficas[2, 1] = t2;
        graficas[2, 2] = t3;
        graficas[2, 3] = t4;

    }


    public void accion(int ele)
    {
        if (clickable)
        {
            this.elegida = ele;
            ComprobarRespuesta();
        }
    }


    void ComprobarRespuesta()
    {
        clickable = !clickable;

        if (this.elegida != this.correcta)
        {
            BajarOpciones();
        }
            else
        { 
            OnGUI2D_graficas.OG2D.SumarScore();
            mandarCambio();

        }


            clickable = !clickable;
        

    }

    void mandarCambio()
    {
        int x = Random.Range(0, 3);
        switch (x) {

            case 0:
                CambiarOpciones(x, 1, 2);
                break;
            case 1:
                CambiarOpciones(x, 0, 2);
                break;
            case 2:
                CambiarOpciones(x, 1, 0);
                break;

        }
        PreguntasScript_graficas.script.PonerPregunta(x + 1);

    }



    void BajarOpciones()
    {
        float y1 = op1.GetComponent<Transform>().position.y;


        float x1 = op1.GetComponent<Transform>().position.x;
        op1.GetComponent<Transform>().position = new Vector2(x1, y1 - 20f);

        float x2 = op2.GetComponent<Transform>().position.x;
        op2.GetComponent<Transform>().position = new Vector2(x2, y1 - 20f);

        float x3 = op3.GetComponent<Transform>().position.x;
        op3.GetComponent<Transform>().position = new Vector2(x3, y1 - 20f);

        
        mandarCambio();
        

        GameManager_graficas.script.bajarVida();
    }
   

 

    void CambiarOpciones(int x, int y, int z)
    {

        

        int xx = Random.Range(0, 3);
        int yy = Random.Range(0, 2);

        switch (xx)
        {
            case 0:
                CambiaImagen(imagenes(x), op1);
                correcta = 1;
                switch (yy)
                {
                    case 0:
                        CambiaImagen(imagenes(y), op2);
                        CambiaImagen(imagenes(z), op3);
                        break;

                    case 1:
                        CambiaImagen(imagenes(y), op3);
                        CambiaImagen(imagenes(z), op2);
                        break;
                }//Y
                break;

            case 1:
                CambiaImagen(imagenes(x), op2);
                correcta = 2;
                switch (yy)
                {
                    case 0:
                        CambiaImagen(imagenes(y), op1);
                        CambiaImagen(imagenes(z), op3);
                        break;

                    case 1:
                        CambiaImagen(imagenes(y), op3);
                        CambiaImagen(imagenes(z), op1);
                        break;
                }//Y
                break;

            case 2:
                CambiaImagen(imagenes(x), op3);
                correcta = 3;
                switch (yy)
                {
                    case 0:
                        CambiaImagen(imagenes(y), op2);
                        CambiaImagen(imagenes(z), op1);
                        break;

                    case 1:
                        CambiaImagen(imagenes(y), op1);
                        CambiaImagen(imagenes(z), op2);
                        break;
                }//Y
                break;



        }//X

    }

    public Sprite imagenes(int x)
    {
        int y = Random.Range(0, 3);

        return graficas[x, y];
    }


    public void CambiaImagen(Sprite sprite, Button gobj)
    {

        gobj.image.overrideSprite = sprite;


    }

}//class

