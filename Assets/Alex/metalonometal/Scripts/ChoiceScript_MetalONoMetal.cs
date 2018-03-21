using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceScript_MetalONoMetal : MonoBehaviour {

    private GameObject Pick;
    private GameObject Mano;
    


    public int choice;
    public bool tchoice;

    /*
    choice false = pick axe;
    choice true = mano;
    */

	// Use this for initialization
	void Awake () {
        Pick = GameObject.FindGameObjectWithTag("pico");
        Mano = GameObject.FindGameObjectWithTag("mano");


        choice = 1;

        setBoolChoiceColor();
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Mano.GetComponent<Renderer>().material.color == Color.black)
        {
            tchoice = true;
        }else
        {
            tchoice = false;
        }

    }

    public void setBoolChoiceColor()
    {

        if (choice == 1)
        {
            Mano.GetComponent<Renderer>().material.color = Color.black;
            Pick.GetComponent<Renderer>().material.color = Color.white;

        }
        else if(choice == 0)
        {
            Pick.GetComponent<Renderer>().material.color = Color.black;
            Mano.GetComponent<Renderer>().material.color = Color.white;

        }


    }


    void OnMouseDown()
    {
        if(this.gameObject == Mano)
        {
            this.choice = 1;
        }
        if(this.gameObject == Pick)
        {
            this.choice = 0;
        }

        setBoolChoiceColor();

    }





}
