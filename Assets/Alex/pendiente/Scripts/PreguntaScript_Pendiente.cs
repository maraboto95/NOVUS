using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntaScript_Pendiente : MonoBehaviour {

    public RespuestaScript_Pendiente scripto;
    public CorrectaScript_Pendiente cor;
    public IncorrectaScript_Pendiente incor;
    public DotScript_Pendiente dots;
    public BotonScript_Pendiente boton;

    public TextMesh PreguntaTextMesh;
    public string texto;

    public int clicks;
    public double posx1;
    public double posy1;
    public double posx2;
    public double posy2;
    public double pendCheck;
    public double pend;

    int correctas = 0;
    int incorrectas = 0;
    int total = 0;

    LineRenderer Line;


    // Use this for initialization
    public void Awake () {
        PreguntaTextMesh = this.gameObject.GetComponent<TextMesh>();

        clicks = 0;

        PreguntaTextMesh.text = "chao";

        nuevaPend();

        Line = GameObject.FindGameObjectWithTag("Linea").GetComponent<LineRenderer>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void getPend()
    {
        pendCheck = (posy2 - posy1) / (posx2 - posx1);
    }

    void nuevaPend()
    {
        double y = Random.Range(1, 6);
        double x = Random.Range(1, 6);
        int neg = Random.Range(1, 3);

        pend = y / x;

        if(neg == 2)
        {
            pend *= -1;
            scripto.RespuestaTextMesh.text = "-" + y.ToString() + "/" + x.ToString();

        }
        else
        {
            scripto.RespuestaTextMesh.text = y.ToString() + "/" + x.ToString();

        }

        PreguntaTextMesh.text = "Elige dos puntos";
        
    }

    public void checkPend()
    {
        getPend();

        if(pendCheck == pend)
        {
            Line.startColor = Color.green;

            Line.endColor = Color.green;
            string texto = scripto.RespuestaTextMesh.text;
            scripto.RespuestaTextMesh.text = "Correcto! " + texto;
            correctas++;
            cor.RTextMesh.text = "C: " + correctas;
        }
        else
        {
            Line.startColor = Color.red;

            Line.endColor = Color.red;

            string texto = scripto.RespuestaTextMesh.text;
            scripto.RespuestaTextMesh.text = "Incorrecto :( " + texto;
            incorrectas++;
            incor.RTextMesh.text = "I: " + incorrectas;

        }

        total++;

        if(total >= 15)
        {
            
            dots.borrarTodo();

            if(correctas >= 10)
            {
                scripto.RespuestaTextMesh.text = "GANASTE";
                PreguntaTextMesh.text = "GANASTE";

                /*
            AQUI VA SCRIPT QUE TE REGRESA A LA CALLE    
            */
                PasarNivelScript.script.GanoPerd(true, "pendiente");


            }
            else
            {
                scripto.RespuestaTextMesh.text = "Perdiste :c";
                PreguntaTextMesh.text = "Perdiste :c";

                /*
                AQUI VA SCRIPT QUE TE REGRESA A LA CASA
                */
                PasarNivelScript.script.GanoPerd(false, "pendiente");


            }

            boton.Awake();

        }
        else
        {
            boton.Activar();
        }
    }


}
