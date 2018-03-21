using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class DotScript_enlaces : MonoBehaviour {


    GameObject [] DotLeft;
    GameObject[] DotRight;
    GameObject[] DotUp;
    GameObject[] DotDown;
    GameObject[] DotM;
    

 


    // Use this for initialization

    void Awake () {

     

        DotLeft = GameObject.FindGameObjectsWithTag("Dot_L");
        DotRight = GameObject.FindGameObjectsWithTag("Dot_R");
        DotUp = GameObject.FindGameObjectsWithTag("Dot_U");
        DotDown = GameObject.FindGameObjectsWithTag("Dot_D");
        DotM = GameObject.FindGameObjectsWithTag("Dot_M");
       

        
    }


    // Update is called once per frame
    void FixedUpdate () {
        TurnOnOffAll();
    }


    
    
    void TurnOnOffAll()
    {
       
                TurnOnOff(DotLeft, "Slot_L");
               
                TurnOnOff(DotRight, "Slot_R");
                
                TurnOnOff(DotUp, "Slot_U");
                
                TurnOnOff(DotDown, "Slot_D");

                TurnOnOff(DotM, "Slot_M");

                        

    }

    void TurnOnOff(GameObject[] GO, string str)
    {

        for (int x = 0; x < GO.Length; x++)
        {
            if (GameObject.FindGameObjectWithTag(str).transform.childCount > 0)
            {
                
                GO[x].GetComponent<Image>().enabled = true;
            }
            else
            {
                GO[x].GetComponent<Image>().enabled = false;

            }
        }
    }


 


}//DotScript

