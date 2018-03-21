using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager_enlaces : MonoBehaviour {

    int compuestoActual;

    public Transform Cl;
    public Transform Mg;
    public Transform H;
    public Transform F;
    public Transform K;
    public Transform S;
    public Transform Na;
    public Transform Br;
    public Transform C;
    public Transform O;
    public Transform N;
    public Transform Dot;



    public Slot_enlaces Slot_U;
    public int Slot_U_Dots;
    public int Slot_U_El;
    public Slot_enlaces Slot_D;
    int Slot_D_Dots;
    int Slot_D_El;
    public Slot_enlaces Slot_R;
    int Slot_R_Dots;
    int Slot_R_El;
    public Slot_enlaces Slot_L;
    int Slot_L_Dots;
    int Slot_L_El;
    public Slot_enlaces Slot_M;
    int Slot_M_Dots;
    int Slot_M_El;

    GameObject[] DotLeft;
    GameObject[] DotRight;
    GameObject[] DotUp;
    GameObject[] DotDown;
    GameObject[] DotM;


    string[,] compuestos = new string[7, 3];
    int[] compuestosInt = new int[7];



    void Awake()
    {
        Slot_D_Dots = 0;
        Slot_D_El = 0;
        Slot_U_Dots = 1;
        Slot_U_El = 1;
        Slot_R_Dots = 0;
        Slot_R_El = 0;
        Slot_M_Dots = 0;
        Slot_M_El = 0;
        Slot_L_Dots = 0;
        Slot_L_El = 0;



        DotLeft = GameObject.FindGameObjectsWithTag("Dot_L");
        DotRight = GameObject.FindGameObjectsWithTag("Dot_R");
        DotUp = GameObject.FindGameObjectsWithTag("Dot_U");
        DotDown = GameObject.FindGameObjectsWithTag("Dot_D");
        DotM = GameObject.FindGameObjectsWithTag("Dot_M");


        compuestoActual = 0;
        llenaArray();


        MandarTodo();



    }


    void FixedUpdate () {
        CheckSlots();
        
        PonerValencias();

    
    }

    void borrarHijos()
    {
        borrarHijos2(DotLeft);
        borrarHijos2(DotRight);
        borrarHijos2(DotUp);
        borrarHijos2(DotDown);
        borrarHijos2(DotM);
        borrarHijos3(Slot_U);
        borrarHijos3(Slot_D);
        borrarHijos3(Slot_L);
        borrarHijos3(Slot_R);
        borrarHijos3(Slot_M);


    }

    void borrarHijos3(Slot_enlaces slt)
    {
        foreach (Transform child in slt.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    void borrarHijos2(GameObject[] gObj)
    {
        for (int x = 0; x <= gObj.Length-1; x++)
        {
            foreach (Transform child in gObj[x].transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        }
    }

    void llenaArray()
    {
        compuestos[0, 0] = "Cloruro de magnesio";
        compuestos[0, 1] = "Mg";
        compuestos[0, 2] = "Cl";
        compuestosInt[0] = 2;

        compuestos[1, 0] = "Ácido fluorhídrico";
        compuestos[1, 1] = "H";
        compuestos[1, 2] = "F";
        compuestosInt[1] = 1;

        compuestos[2, 0] = "Sulfuro de potasio";
        compuestos[2, 1] = "S";
        compuestos[2, 2] = "K";
        compuestosInt[2] = 2;

        compuestos[3, 0] = "Bromuro de sodio";
        compuestos[3, 1] = "Br";
        compuestos[3, 2] = "Na";
        compuestosInt[3] = 1;

        compuestos[4, 0] = "Dióxido de carbono";
        compuestos[4, 1] = "C";
        compuestos[4, 2] = "O";
        compuestosInt[4] = 2;

        compuestos[5, 0] = "Agua";
        compuestos[5, 1] = "O";
        compuestos[5, 2] = "H";
        compuestosInt[5] = 2;

        compuestos[6, 0] = "Amoniaco";
        compuestos[6, 1] = "N";
        compuestos[6, 2] = "H";
        compuestosInt[6] = 3;

    }


    void GameOver()
    {
        if(OnGUI2D_enlaces.OG2D.score >= 70)
        {
            /* GANAR */
            PasarNivelScript.script.GanoPerd(true, "enlances");

        }
        else
        {
            /* PERDER */
            PasarNivelScript.script.GanoPerd(false, "enlances");

        }
    }


    void MandarTodo()
    {
        if(compuestoActual == 7)
        {
            GameOver();
        }
        else
        {
            borrarHijos();
            PreguntaScript_enlaces.script.PonerPregunta(compuestos[compuestoActual, 0]);

        }

    }

    public void BotonOK()
    {
        CheckCorrecto(compuestos[compuestoActual, 1], compuestos[compuestoActual, 2], compuestosInt[compuestoActual]);
        MandarTodo();
    }

    void CheckCorrecto(string primario, string secundario, int cuantos)
    {
        if(ValenciasEnCero())
        {
            OnGUI2D_enlaces.OG2D.SumarCinco();
        }
        if(compuestoActual == 1 || compuestoActual == 3)
        {
            if (QueCompuesto(secundario, primario, cuantos))
            {
                OnGUI2D_enlaces.OG2D.SumarDiez();
            }
        }
        if(QueCompuesto(primario, secundario, cuantos))
        {
            OnGUI2D_enlaces.OG2D.SumarDiez();
        }

        compuestoActual++;


    }

     void CheckSlots()
    {
        Slot_Check(Cl, "Slot_Cl");
        Slot_Check(Mg, "Slot_Mg");
        Slot_Check(H, "Slot_H");
        Slot_Check(F, "Slot_F");
        Slot_Check(K, "Slot_K");
        Slot_Check(S, "Slot_S");
        Slot_Check(Na, "Slot_Na");
        Slot_Check(Br, "Slot_Br");
        Slot_Check(C, "Slot_C");
        Slot_Check(O, "Slot_O");
        Slot_Check(N, "Slot_N");
        Slot_Check(Dot, "Slot_Dot");
    }

    void Slot_Check(Transform obj, string str)
    {
        if (GameObject.FindGameObjectWithTag(str).transform.childCount < 1)
        {
            Instantiate(obj, GameObject.FindGameObjectWithTag(str).transform);
        }
    }

    void PonerValencias()
    {
        CheckDots();
        ChildCheck();

        SumaValencia(Slot_L, Slot_L_El, Slot_L_Dots);
        SumaValencia(Slot_R, Slot_R_El, Slot_R_Dots);
        SumaValencia(Slot_D, Slot_D_El, Slot_D_Dots);
        SumaValencia(Slot_U, Slot_U_El, Slot_U_Dots);
        SumaValencia(Slot_M, Slot_M_El, Slot_M_Dots);
    }

    void SumaValencia(Slot_enlaces slt, int uno, int dos)
    {
        slt.valencia = uno + dos;
    }

    void CheckDots()
    {
        Slot_L_Dots = Dot_Check(DotLeft);
        Slot_R_Dots = Dot_Check(DotRight);
        Slot_U_Dots = Dot_Check(DotUp);
        Slot_D_Dots = Dot_Check(DotDown);
        Slot_M_Dots = Dot_Check(DotM);



    }

    private static int Dot_Check(GameObject[] GO)
    {
        int dots = 0;

        for (int x = 0; x < GO.Length; x++)
        {
            if (GO[x].transform.childCount > 0)
            {
                dots++;
            }
        }

        return dots;
    }

    void ChildCheck()
    {
        Slot_L_El = Check_Childs("Slot_L");
        Slot_R_El = Check_Childs("Slot_R");
        Slot_U_El = Check_Childs("Slot_U");
        Slot_D_El = Check_Childs("Slot_D");
        Slot_M_El = Check_Childs("Slot_M");
    }

    private static int Check_Childs(string str)
    {
        
        if (GameObject.FindGameObjectWithTag(str).transform.childCount > 0)
        {
            switch (GameObject.FindGameObjectWithTag(str).transform.GetChild(0).tag)
            {
                case "Br":
                    return -7;
                    
                case "Cl":
                    return -7;
                    
                case "Mg":
                    return -2;
                    
                case "H":
                    return -1;
                    
                case "F":
                    return -7;
                    
                case "K":
                    return -1;
                    
                case "S":
                    return -6;
                    
                case "Na":
                    return -1;
                    
                case "O":
                    return -6;
                    
                case "C":
                    return -4;
                    
                case "N":
                    return -5;
                    
            }
        }
        return 0;
    }

    private bool ValenciasEnCero()
    {
        return Slot_L.valencia == 0 && Slot_R.valencia == 0 && Slot_U.valencia == 0 && Slot_D.valencia == 0 && Slot_M.valencia == 0;
    }

    bool QueCompuesto(string central, string lateral, int lateralus)
    {
        if (Slot_M.item)
        {

            if (Slot_M.item.tag == central)
            {
                if (CuantosExtras(lateralus))
                {
                    if(CuantosBien(lateral, lateralus))
                    {
                        return true;
                    }
                    
                }
            }
        }//if Slot_M.item
        return false;
    }

    bool CuantosExtras(int debe)
    {
        int son = 0;
        if (Slot_D.item) son++;
        if (Slot_L.item) son++;
        if (Slot_R.item) son++;
        if (Slot_U.item) son++;

        return son == debe;
    }

    bool EstaBien(Slot_enlaces slt, string str)
    {
       return slt.item.tag == str;
    }
    
    bool CuantosBien(string str, int debe)
    {
        int cuantos = 0;

        if (Slot_L.item)
        {
            if (EstaBien(Slot_L, str))
            {
                cuantos++;
            }
            else
            {
                return false;
            }

        }
        if (Slot_R.item)
        {
            if (EstaBien(Slot_R, str))
            {
                cuantos++;
            }
            else
            {
                return false;
            }

        }
        if (Slot_U.item)
        {
            if (EstaBien(Slot_U, str))
            {
                cuantos++;
            }
            else
            {
                return false;
            }

        }
        if (Slot_D.item)
        {
            if (EstaBien(Slot_D, str))
            {
                cuantos++;
            }
            else
            {
                return false;
            }

        }

        return debe == cuantos;
    }


}//class
