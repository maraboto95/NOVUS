using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class OpcionesScript_funciones : MonoBehaviour {

    public Button b1, b2, b3, b4;
    public Text t1, t2, t3, t4;
    public int opcion;

	// Use this for initialization
	void Awake () {

        AcomodarOpciones("uno", "dos", "tres", "cuatro");
 
	}
	
	// Update is called once per frame
	void Update () {

			}




   void AcomodarOpciones(string a, string b, string c, string d)
    {

        int x = Random.Range(0, 4);
        int y = Random.Range(0, 3);
        int z = Random.Range(0, 2);

        switch (x)
        {
            case 0: t1.text = a;
                this.opcion = 1;
                switch (y)
                {
                    case 0: t2.text = b;


                        switch (z)
                        {
                            case 0: t3.text = c;
                                t4.text = d;
                                break;
                            case 1: t4.text = c;
                                t3.text = d;
                                break;
                        } //Z
                        break;

                    case 1: t3.text = b;

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

                    case 2: t4.text = b;


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


            case 1: t2.text = a;
                this.opcion = 2;

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


            case 2: t3.text = a;
                this.opcion = 3;

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


            case 3: t4.text = a;
                this.opcion = 4;

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

    void PonerOpcionesEImagen()
    {
        int x = Random.Range(0, 4);

        switch (x)
        {
            case 0:
                ImagenScript_funciones.imgscript.CambiaImagen(ImagenScript_funciones.imgscript.imagenes(0));
                AcomodarOpciones("uno", "dos", "tres", "cuatro");
                break;
            case 1:
                ImagenScript_funciones.imgscript.CambiaImagen(ImagenScript_funciones.imgscript.imagenes(1));
                AcomodarOpciones("dos", "uno", "tres", "cuatro");
                break;
            case 2:
                ImagenScript_funciones.imgscript.CambiaImagen(ImagenScript_funciones.imgscript.imagenes(2));
                AcomodarOpciones("tres", "dos", "uno", "cuatro");
                break;
            case 3:
                ImagenScript_funciones.imgscript.CambiaImagen(ImagenScript_funciones.imgscript.imagenes(3));
                AcomodarOpciones("cuatro", "dos", "tres", "uno");
                break;
        }

    }

    public void ClickRespuesta(int x)
    {

        if (x == opcion)
        {
            OnGUI2D_funciones.OG2D.SumarScore();
            
        }
        else
        {
            ImagenScript_funciones.imgscript.Equivocado();

        }

        PonerOpcionesEImagen();

    }


}
