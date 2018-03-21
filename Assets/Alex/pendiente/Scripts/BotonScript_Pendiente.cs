using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript_Pendiente : MonoBehaviour {



    public PreguntaScript_Pendiente scripto;
    public DotScript_Pendiente scripta;


    // Use this for initialization
    public void Awake () {


        GameObject.FindGameObjectWithTag("Boton").GetComponent<SpriteRenderer>().enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnMouseDown()
    {

        scripta.Awake();
            scripto.Awake();
            Awake();
        
    }


    public void Activar()
    {
        GameObject.FindGameObjectWithTag("Boton").GetComponent<SpriteRenderer>().enabled = true;

    }




}
