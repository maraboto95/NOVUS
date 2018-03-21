using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntaScript_enlaces : MonoBehaviour
{

    public static PreguntaScript_enlaces script;

    public TextMesh PreguntasTextMesh;

    public string texto;



    void Awake()
    {

        script = this;
        PreguntasTextMesh = this.gameObject.GetComponent<TextMesh>();
    }



    public void PonerPregunta(string str)
    {

        PreguntasTextMesh.text = str;
    }

    

}
