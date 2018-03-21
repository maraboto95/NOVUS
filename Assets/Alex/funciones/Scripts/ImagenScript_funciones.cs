using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagenScript_funciones : MonoBehaviour {

    public int vidas;

    public static ImagenScript_funciones imgscript;

    public Sprite u1, u2, u3, u4, d1, d2, d3, d4, t1, t2, t3, t4, c1, c2, c3, c4;
    Sprite[,] graficas = new Sprite[4,4]; 

    void Awake() {
        this.vidas = 5;
        imgscript = this;
        llenaArray();
    }

    void llenaArray()
    {
        graficas[0, 0] = u1;
        graficas[0, 1] = u2;
        graficas[0, 2] = u3;
        graficas[0, 3] = u4;
        graficas[1, 0] = d1;
        graficas[1, 1] = d2;
        graficas[1, 2] = d3;
        graficas[1, 3] = d4;
        graficas[2, 0] = t1;
        graficas[2, 1] = t2;
        graficas[2, 2] = t3;
        graficas[2, 3] = t4;
        graficas[3, 0] = c1;
        graficas[3, 1] = c2;
        graficas[3, 2] = c3;
        graficas[3, 3] = c4;

    }

    void Update () {
	}

    public void Equivocado()
    {
        if(this.vidas <= 1)
        {

            if (OnGUI2D_funciones.OG2D.score >= 70)
            {
                /* AQUI VA EL CODIGO DE GANAR EL NIVEL */

                PasarNivelScript.script.GanoPerd(true, "funciones");

            }
            else
            {
                /* AQUI VA EL CODIGO DE PERDER EL NIVEL */

                PasarNivelScript.script.GanoPerd(false, "funciones");

            }


        }
        else { 
        RestaVidas();
        ImagenTamano();

        }
    }

    void ImagenTamano()
    {
        this.gameObject.transform.localScale -= new Vector3(0.3f, 0.3f, 0);
    }

    void RestaVidas()
    {
        this.vidas--;
    }



    public Sprite imagenes(int x)
    {
        int y = Random.Range(0, 4);

        return graficas[x, y];
        }
        
    

    public void CambiaImagen(Sprite sprite)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite;

    }



}
