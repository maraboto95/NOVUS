using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonesScript_pelea2 : MonoBehaviour {


    public Button b1, b2, b3, b4;
    public Text t1, t2, t3, t4, pregunta;

    private int opcion;

    // Use this for initialization
    void Awake()
    {
        PonerOpcionesYPregunta();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        

    }


   


    void AcomodarOpciones(string a, string b, string c, string d)
    {

        int x = Random.Range(0, 4);
        int y = Random.Range(0, 3);
        int z = Random.Range(0, 2);

        switch (x)
        {
            case 0:
                t1.text = a;
                opcion = 1;

                switch (y)
                {
                    case 0:
                        t2.text = b;


                        switch (z)
                        {
                            case 0:
                                t3.text = c;
                                t4.text = d;
                                break;
                            case 1:
                                t4.text = c;
                                t3.text = d;
                                break;
                        } //Z
                        break;

                    case 1:
                        t3.text = b;

                        switch (z)
                        {
                            case 0:
                                t2.text = c;
                                t4.text = d;
                                break;
                            case 1:
                                t4.text = c;
                                t2.text = d;
                                break;
                        } //Z
                        break;

                    case 2:
                        t4.text = b;


                        switch (z)
                        {
                            case 0:
                                t2.text = c;
                                t3.text = d;
                                break;
                            case 1:
                                t3.text = c;
                                t2.text = d;
                                break;
                        } //Z
                        break;

                }//Y

                break;


            case 1:
                t2.text = a;
                opcion = 2;

                switch (y)
                {
                    case 0:
                        t1.text = b;


                        switch (z)
                        {
                            case 0:
                                t3.text = c;
                                t4.text = d;
                                break;
                            case 1:
                                t4.text = c;
                                t3.text = d;
                                break;
                        } //Z
                        break;

                    case 1:
                        t3.text = b;

                        switch (z)
                        {
                            case 0:
                                t1.text = c;
                                t4.text = d;
                                break;
                            case 1:
                                t4.text = c;
                                t1.text = d;
                                break;
                        } //Z
                        break;

                    case 2:
                        t4.text = b;


                        switch (z)
                        {
                            case 0:
                                t1.text = c;
                                t3.text = d;
                                break;
                            case 1:
                                t3.text = c;
                                t1.text = d;
                                break;
                        } //Z
                        break;

                }//Y
                break;


            case 2:
                t3.text = a;
                opcion = 3;

                switch (y)
                {
                    case 0:
                        t2.text = b;


                        switch (z)
                        {
                            case 0:
                                t1.text = c;
                                t4.text = d;
                                break;
                            case 1:
                                t4.text = c;
                                t1.text = d;
                                break;
                        } //Z
                        break;

                    case 1:
                        t1.text = b;

                        switch (z)
                        {
                            case 0:
                                t2.text = c;
                                t4.text = d;
                                break;
                            case 1:
                                t4.text = c;
                                t2.text = d;
                                break;
                        } //Z
                        break;

                    case 2:
                        t4.text = b;


                        switch (z)
                        {
                            case 0:
                                t2.text = c;
                                t1.text = d;
                                break;
                            case 1:
                                t1.text = c;
                                t2.text = d;
                                break;
                        } //Z
                        break;

                }//Y
                break;


            case 3:
                t4.text = a;
                opcion = 4;

                switch (y)
                {
                    case 0:
                        t2.text = b;


                        switch (z)
                        {
                            case 0:
                                t3.text = c;
                                t1.text = d;
                                break;
                            case 1:
                                t1.text = c;
                                t3.text = d;
                                break;
                        } //Z
                        break;

                    case 1:
                        t3.text = b;

                        switch (z)
                        {
                            case 0:
                                t2.text = c;
                                t1.text = d;
                                break;
                            case 1:
                                t1.text = c;
                                t2.text = d;
                                break;
                        } //Z
                        break;

                    case 2:
                        t1.text = b;


                        switch (z)
                        {
                            case 0:
                                t2.text = c;
                                t3.text = d;
                                break;
                            case 1:
                                t3.text = c;
                                t2.text = d;
                                break;
                        } //Z
                        break;

                }//Y
                break;
        } //X


    } //AcomodarOpciones

    
        

    void PonerPregunta(string a)
    {
        pregunta.text = a;
    }



    public void ClickRespuesta(int x)
    {

        if (x == opcion)
        {
            PlayerScript_pelea2.script.avanza1();
        }
        else
        {
            EnemyScript_pelea2.script.avanza1();
        }


        PonerOpcionesYPregunta();


    }

    void PonerOpcionesYPregunta()
    {
        /*
        
        0) Pregunta
        1) Correcta
        2-4) Incorrectas
        
        
        */
        string[,] array = new string[17, 5];
        array[0, 0] = "Son las fuerzas de atracción que mantienen unidos entre sí a los átomos o iones, paraformar moléculas o cristales.";
        array[0, 1] = "Enlaces químicos";
        array[0, 2] = "Enlaces iónicos";
        array[0, 3] = "Enlaces covalentes";
        array[0, 4] = "Enlaces";

        array[1, 0] = "El enlace originado por la transferencia de electrones de un metal a un no metal es:";
        array[1, 1] = "iónico";
        array[1, 2] = "metálico";
        array[1, 3] = "covalente simple";
        array[1, 4] = "covalente coordinado";

        array[2, 0] = "Un átomo de número atómico 16 y número de masa 32 ganó 2 electrones; su número de protones es: ";
        array[2, 1] = "18";
        array[2, 2] = "16";
        array[2, 3] = "32";
        array[2, 4] = "34";

        array[3, 0] = "Un átomo tiene 35 electrones, 35 protones y 45 neutrones; su número de masa es:";
        array[3, 1] = "80";
        array[3, 2] = "115";
        array[3, 3] = "35";
        array[3, 4] = "70";

        array[4, 0] = "Un átomo tiene 15 electrones, 15 protones y 16 neutrones; su número atómico es:";
        array[4, 1] = "15";
        array[4, 2] = "30";
        array[4, 3] = "31";
        array[4, 4] = "16";

        array[5, 0] = "Un elemento se encuentra en el grupo VA y en el tercer periodo, ¿cuántos electrones requiere ganar para completar su octeto?";
        array[5, 1] = "3";
        array[5, 2] = "1";
        array[5, 3] = "2";
        array[5, 4] = "5";

        array[6, 0] = "El tipo de enlace presente en el compuesto CaF 2 es:";
        array[6, 1] = "iónico";
        array[6, 2] = "covalente simple";
        array[6, 3] = "covalente coordinado";
        array[6, 4] = "metálico";

        array[7, 0] = "Son los electrones que se encuentran en el último nivel de energía.";
        array[7, 1] = "Electrones de valencia";
        array[7, 2] = "Valencia principal";
        array[7, 3] = "Regla del octeto";
        array[7, 4] = "Electronegatividad";

        array[8, 0] = "Fuerza de atracción que mantiene unidos a los átomos en un compuesto.";
        array[8, 1] = "Enlace químico";
        array[8, 2] = "Valencia";
        array[8, 3] = "Octeto";
        array[8, 4] = "Radio atómico";

        array[9, 0] = "Un átomo de número atómico 19 y número de masa 39 perdió 1 electrón; su número de electrones es:";
        array[9, 1] = "18";
        array[9, 2] = "19";
        array[9, 3] = "40";
        array[9, 4] = "20";

        array[10, 0] = "Un átomo tiene número atómico 33 y número de masa 75; el número de neutrones que tiene es:";
        array[10, 1] = "42";
        array[10, 2] = "108";
        array[10, 3] = "75";
        array[10, 4] = "33";

        array[11, 0] = "Este enlace químico es el resultado de la unión de un “metal” con un “no metal”.";
        array[11, 1] = "Enlace iónico";
        array[11, 2] = "Enlace covalente simple";
        array[11, 3] = "Enlace covalente coordinado";
        array[11, 4] = "Enlace metálico";

        array[12, 0] = "Los puntos del diagrama de Lewis de cada átomo representan:";
        array[12, 1] = "Electrones de valencia";
        array[12, 2] = "El número atómico";
        array[12, 3] = "# de electrones";
        array[12, 4] = "Electrones del subnivel “p”";

        array[13, 0] = "El NaCl es un compuesto unido por un enlace:";
        array[13, 1] = "Iónico";
        array[13, 2] = "Covalente sencillo";
        array[13, 3] = "Covalente doble";
        array[13, 4] = "Covalente coordinado";

        array[14, 0] = "Los átomos de la molécula de O 2 están unidos por el enlace:";
        array[14, 1] = "Enlace covalente doble";
        array[14, 2] = "Enlace iónico";
        array[14, 3] = "Enlace covalente simple";
        array[14, 4] = "Enlace covalente coordinado";

        array[15, 0] = "Los átomos de la molécula CCl 4 están unidos por cuatro enlaces del tipo:";
        array[15, 1] = "Enlace covalente simple";
        array[15, 2] = "Enlace iónico";
        array[15, 3] = "Enlace covalente doble";
        array[15, 4] = "Enlace covalente triple";

        array[16, 0] = "Los átomos de la molécula CaO se encuentran unidos por el enlace:";
        array[16, 1] = "Enlace iónico";
        array[16, 2] = "Enlace covalente simple";
        array[16, 3] = "Enlace covalente coordinado";
        array[16, 4] = "Enlace covalente doble.";

        int x = Random.Range(0, 17);

        PonerPregunta(array[x, 0]);
        AcomodarOpciones(array[x, 1], array[x, 2], array[x, 3], array[x, 4]);





    }



}
