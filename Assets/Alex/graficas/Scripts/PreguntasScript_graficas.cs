using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntasScript_graficas : MonoBehaviour
{

    public static PreguntasScript_graficas script;

    public TextMesh PreguntasTextMesh;

    public string texto;



    void Awake()
    {

        script = this;
        PreguntasTextMesh = this.gameObject.GetComponent<TextMesh>();


    }



    public void PonerPregunta(int x)
    {

        PreguntasTextMesh.text = "Elige la ecuación de grado " + x.ToString();
    }

    public void PonerPerdiste()
    {

        PreguntasTextMesh.text = "Perdiste";

        this.gameObject.GetComponent<Transform>().position = new Vector2(0, 0);


    }

}
