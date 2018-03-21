using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript_MetalONoMetal : MonoBehaviour {


    
    public ChoiceScript_MetalONoMetal choice;

    [SerializeField]
    private GameObject metal;

    [SerializeField]
    private GameObject nometal;

    public bool soymetal;


    private GameObject roca;
    private RockScript_MetalONoMetal rocaScript;
    private TextMesh rocaText;

    // Use this for initialization
    void Awake () {

        
    }
	
	// Update is called once per frame
	void Update () {

    }

    void InstantiateBalls()
    {

        string[] nombreMet = new string[118];

        nombreMet[0] = "H";
        nombreMet[1] = "He";
        nombreMet[2] = "B";
        nombreMet[3] = "C";
        nombreMet[4] = "N";
        nombreMet[5] = "O";
        nombreMet[6] = "F";
        nombreMet[7] = "Ne";
        nombreMet[8] = "Si";
        nombreMet[9] = "P";
        nombreMet[10] = "S";
        nombreMet[11] = "Cl";
        nombreMet[12] = "Ar";
        nombreMet[13] = "Ge";
        nombreMet[14] = "As";
        nombreMet[15] = "Se";
        nombreMet[16] = "Br";
        nombreMet[17] = "Kr";
        nombreMet[18] = "Sb";
        nombreMet[19] = "Te";
        nombreMet[20] = "I";
        nombreMet[21] = "Xe";
        nombreMet[22] = "Po";
        nombreMet[23] = "At";
        nombreMet[24] = "Rn";
        nombreMet[25] = "Uus";
        nombreMet[26] = "Uuo";
        nombreMet[27] = "Li";
        nombreMet[28] = "Be";
        nombreMet[29] = "Na";
        nombreMet[30] = "Mg";
        nombreMet[31] = "Al";
        nombreMet[32] = "Ca";
        nombreMet[33] = "K";
        nombreMet[34] = "Sc";
        nombreMet[35] = "Ti";
        nombreMet[36] = "V";
        nombreMet[37] = "Cr";
        nombreMet[38] = "Mn";
        nombreMet[39] = "Fe";
        nombreMet[40] = "Co";
        nombreMet[41] = "Ni";
        nombreMet[42] = "Cu";
        nombreMet[43] = "Zn";
        nombreMet[44] = "Ga";
        nombreMet[45] = "Rb";
        nombreMet[46] = "Sr";
        nombreMet[47] = "Y";
        nombreMet[48] = "Zr";
        nombreMet[49] = "Nb";
        nombreMet[50] = "Mo";
        nombreMet[51] = "Tc";
        nombreMet[52] = "Ru";
        nombreMet[53] = "Rh";
        nombreMet[54] = "Pd";
        nombreMet[55] = "Ag";
        nombreMet[56] = "Cd";
        nombreMet[57] = "In";
        nombreMet[58] = "Sn";
        nombreMet[59] = "Cs";
        nombreMet[60] = "Ba";
        nombreMet[61] = "Hg";
        nombreMet[62] = "Ta";
        nombreMet[63] = "W";
        nombreMet[64] = "Re";
        nombreMet[65] = "Os";
        nombreMet[66] = "Ir";
        nombreMet[67] = "Pt";
        nombreMet[68] = "Au";
        nombreMet[69] = "Hg";
        nombreMet[70] = "Tl";
        nombreMet[71] = "Pb";
        nombreMet[72] = "Bi";
        nombreMet[73] = "Fr";
        nombreMet[74] = "Ra";
        nombreMet[75] = "Rf";
        nombreMet[76] = "Db";
        nombreMet[77] = "Sg";
        nombreMet[78] = "Bh";
        nombreMet[79] = "Hs";
        nombreMet[80] = "Mt";
        nombreMet[81] = "Ds";
        nombreMet[82] = "Rg";
        nombreMet[83] = "Cn";
        nombreMet[84] = "Uut";
        nombreMet[85] = "Uuq";
        nombreMet[86] = "Uup";
        nombreMet[87] = "Uuh";
        nombreMet[88] = "La";
        nombreMet[89] = "Ce";
        nombreMet[90] = "Pr";
        nombreMet[91] = "Nd";
        nombreMet[92] = "Pm";
        nombreMet[93] = "Sm";
        nombreMet[94] = "Eu";
        nombreMet[95] = "Gd";
        nombreMet[96] = "Tb";
        nombreMet[97] = "Dy";
        nombreMet[98] = "Ho";
        nombreMet[99] = "Er";
        nombreMet[100] = "Tm";
        nombreMet[101] = "Yb";
        nombreMet[102] = "Lu";
        nombreMet[103] = "Ac";
        nombreMet[104] = "Th";
        nombreMet[105] = "Pa";
        nombreMet[106] = "U";
        nombreMet[107] = "Np";
        nombreMet[108] = "Pu";
        nombreMet[109] = "Am";
        nombreMet[110] = "Cm";
        nombreMet[111] = "Bk";
        nombreMet[112] = "Cf";
        nombreMet[113] = "Es";
        nombreMet[114] = "Fm";
        nombreMet[115] = "Md";
        nombreMet[116] = "No";
        nombreMet[117] = "Lr";
        
    









        if (this.gameObject.tag != "SmallestMetal" && this.gameObject.tag != "SmallestNoMetal")
        {


            int jue = Random.Range(0, 2);

            if (jue == 0)
            {

                roca = Instantiate(metal);

                roca.name = metal.name;

                rocaScript = roca.GetComponent<RockScript_MetalONoMetal>();

                rocaText = roca.GetComponentInChildren<TextMesh>();

                rocaScript.soymetal = true;

               rocaText.text = nombreMet[Random.Range(27, 117)];



            }
            else if (jue == 1)
            {

                roca = Instantiate(nometal);

                roca.name = nometal.name;

                rocaScript = roca.GetComponent<RockScript_MetalONoMetal>();

                rocaText = roca.GetComponentInChildren<TextMesh>();

                rocaScript.soymetal = false;

               rocaText.text = nombreMet[Random.Range(0, 26)];



            }
            


          


        }
    }

    

    void InitializeBallsAndTurnOffCurrentBall()
    {
        InstantiateBalls();

        Vector3 temp = transform.position;
        roca.transform.position = temp;


       

        gameObject.SetActive(false);
    }


    void OnMouseDown()
    {


       /// if (vidaRestante > 0)
       // {
            if (GameObject.FindGameObjectWithTag("pico").GetComponent<Renderer>().material.color == Color.white)
            {
            if (soymetal == false)
                {
                    if (this.gameObject.tag != "SmallestNoMetal")
                    {
                        InitializeBallsAndTurnOffCurrentBall();
                    }
                    else
                    {
                        gameObject.SetActive(false);
                    }
                }
                else
                {
                VidaScript_MetalONoMetal.vidas.bajarVida();
                }

            }
        if (GameObject.FindGameObjectWithTag("pico").GetComponent<Renderer>().material.color == Color.black)
        {
                if (soymetal == true)
                {
                    if (this.gameObject.tag != "SmallestMetal")
                    {
                        InitializeBallsAndTurnOffCurrentBall();
                    }
                    else
                    {
                        gameObject.SetActive(false);
                    }
                }
                else
                {
                VidaScript_MetalONoMetal.vidas.bajarVida();
                }
            }

      //  }
        
        
            
        
    }
    


   




}
