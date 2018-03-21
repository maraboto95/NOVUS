using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraficaScript_graphicornot : MonoBehaviour {

    public static GraficaScript_graphicornot script;

    public Sprite spr1, spr2, spr3, spr4, spr5, spr6, spr7, spr8, spr9, spr10, spr11, spr12, spr13, spr14, spr15, spr16, spr17, spr18, spr19, spr20;

    Sprite[] graficas = new Sprite[20];

    public SpriteRenderer grafica;

    void Awake () {
        script = this;
        llenaArray();
	}

    void llenaArray()
    {
        graficas[0] = spr1;
        graficas[1] = spr2;
        graficas[2] = spr3;
        graficas[3] = spr4;
        graficas[4] = spr5;
        graficas[5] = spr6;
        graficas[6] = spr7;
        graficas[7] = spr8;
        graficas[8] = spr9;
        graficas[9] = spr10;
        graficas[10] = spr11;
        graficas[11] = spr12;
        graficas[12] = spr13;
        graficas[13] = spr14;
        graficas[14] = spr15;
        graficas[15] = spr16;
        graficas[16] = spr17;
        graficas[17] = spr18;
        graficas[18] = spr19;
        graficas[19] = spr20;
      
    }

    public void ponerGrafica(int x)
    {
        grafica.sprite = graficas[x];
    }


}
