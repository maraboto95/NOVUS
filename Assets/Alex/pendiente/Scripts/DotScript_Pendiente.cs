using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotScript_Pendiente : MonoBehaviour {


    public double PosX;
    public double PosY;

    bool clickable;
    bool clicked;

    public PreguntaScript_Pendiente scripto;
    public BotonScript_Pendiente boton;

    LineRenderer Line;

    

    // Use this for initialization
    public void Awake () {

        

        

        Line = GameObject.FindGameObjectWithTag("Linea").GetComponent<LineRenderer>();




        GameObject[] dots = GameObject.FindGameObjectsWithTag("Punto");
        foreach (GameObject punto in dots)
        {
            punto.GetComponent<Renderer>().material.color = Color.white;

            clickable = true;
            clicked = false;
        }


        var points = new Vector3[2];

        

        points[0] = new Vector3(0, 0, 0);
        points[1] = new Vector3(0, 0, 0f);

        Line.SetPositions(points);



    }

    // Update is called once per frame
    void Update () {
		
	}


    void OnMouseDown()
    {
        AsignaXY();

    }//OnMouseDown


    void AsignaXY()
    {




        if(scripto.clicks == 0)
        {

            scripto.PreguntaTextMesh.text = "Elige uno más";

            scripto.posx1 = this.PosX;
            scripto.posy1 = this.PosY;
            scripto.clicks++;
            this.gameObject.GetComponent<Renderer>().material.color = Color.black;
            this.clickable = false;
            //GameObject.FindGameObjectWithTag("Linea").get
            //GameObject.FindGameObjectWithTag("Opcion1").GetComponent<Transform>().position = new Vector2(x1, y1 - 1f);



        }
        else if(scripto.clicks == 1) {
            scripto.posx2 = this.PosX;
            scripto.posy2 = this.PosY;
            scripto.clicks++;
            this.gameObject.GetComponent<Renderer>().material.color = Color.black;
            this.clickable = false;

            dibujaLinea();

        }

        




    }//asinga XY

    void dibujaLinea()
    {
        var points = new Vector3[2];

        float x1 = (float)scripto.posx1 / 2;
        float y1 = (float)scripto.posy1 / 2;
        float x2 = (float)scripto.posx2 / 2;
        float y2 = (float)scripto.posy2 / 2;

        points[0] = new Vector3(x1, y1, 0);
        points[1] = new Vector3(x2, y2, 0f);

        Line.SetPositions(points);
        if (scripto.pend > 0)
        {
            scripto.PreguntaTextMesh.text = "Tu respuesta = " + Mathf.Abs(y1 - y2) * 2 + "/" + Mathf.Abs(x1 - x2) * 2;
        }
        else
        {
            scripto.PreguntaTextMesh.text = "Tu respuesta = -" + Mathf.Abs(y1 - y2) * 2 + "/" + Mathf.Abs(x1 - x2) * 2;

        }
        scripto.checkPend();


    }

    public void borrarTodo()
    {


        GameObject[] dots = GameObject.FindGameObjectsWithTag("Punto");
        foreach (GameObject punto in dots)
        {
            punto.GetComponent<Renderer>().enabled = false; 

            clickable = false;
        }


        var points = new Vector3[2];



        points[0] = new Vector3(0, 0, 0);
        points[1] = new Vector3(0, 0, 0f);

        Line.SetPositions(points);


    }




}
