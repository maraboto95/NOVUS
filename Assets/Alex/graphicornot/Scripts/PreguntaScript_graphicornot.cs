using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntaScript_graphicornot : MonoBehaviour {

    public static PreguntaScript_graphicornot script;

    public TextMesh pregunta;

    public string[,] ecuaciones = new string[20,4];


    void Awake () {
        script = this;
        llenaArray();
	}

    void llenaArray()
    {
        ecuaciones[0, 0] = "f(x)=x² + 1 ";
        ecuaciones[0, 1] = "f(x)=x² + 2";
        ecuaciones[0, 2] = "f(x)=x²";
        ecuaciones[0, 3] = "f(x)=x² - 1 ";

        ecuaciones[1, 0] = "f(x)=x² - 4";
        ecuaciones[1, 1] = "f(x)=x² - 2";
        ecuaciones[1, 2] = "f(x)=x² - 1";
        ecuaciones[1, 3] = "f(x)=x² + 1";

        ecuaciones[2, 0] = "f(x)=-x²";
        ecuaciones[2, 1] = "f(x)=x² - 4";
        ecuaciones[2, 2] = "f(x)=x² - 1";
        ecuaciones[2, 3] = "f(x)=-x² + 1";

        ecuaciones[3, 0] = "f(x)=1/x";
        ecuaciones[3, 1] = "f(x)=x² - x²";
        ecuaciones[3, 2] = "f(x)=1/x²";
        ecuaciones[3, 3] = "f(x)=x²/0";

        ecuaciones[4, 0] = "f(x)=1/x²";
        ecuaciones[4, 1] = "f(x)=1/x";
        ecuaciones[4, 2] = "f(x)=x²/0";
        ecuaciones[4, 3] = "f(x)=x²/100";

        ecuaciones[5, 0] = "f(x)=x+1";
        ecuaciones[5, 1] = "f(x)=x";
        ecuaciones[5, 2] = "f(x)=x-1";
        ecuaciones[5, 3] = "f(x)=x+2";
    
        ecuaciones[6, 0] = "f(x)=-(x-2)² + 4";
        ecuaciones[6, 1] = "f(x)=-x² - 2"; 
        ecuaciones[6, 2] = "f(x)=-x²-2 + 4";
        ecuaciones[6, 3] = "f(x)=-(x-2)²";

        ecuaciones[7, 0] = "f(x)=x³";
        ecuaciones[7, 1] = "f(x)=(x²)²";
        ecuaciones[7, 2] = "f(x)=x/x²";
        ecuaciones[7, 3] = "f(x)=x³/2";

        ecuaciones[8, 0] = "f(x)=(x+2)³";
        ecuaciones[8, 1] = "f(x)=x³ + 2";
        ecuaciones[8, 2] = "f(x)=x³ - 2";
        ecuaciones[8, 3] = "f(x)=x³";

        ecuaciones[9, 0] = "f(x)=x³ + 2";
        ecuaciones[9, 1] = "f(x)=(x+2)³";
        ecuaciones[9, 2] = "f(x)=(x-2)³";
        ecuaciones[9, 3] = "f(x)=x³ - 2";

        ecuaciones[10, 0] = "f(x)=x⁴";
        ecuaciones[10, 1] = "f(x)=x²/2";
        ecuaciones[10, 2] = "f(x)=2x²";
        ecuaciones[10, 3] = "f(x)=4x²";

        ecuaciones[11, 0] = "f(x)=x⁴ + 2x³";
        ecuaciones[11, 1] = "f(x)=x²  + (x² + 2)";
        ecuaciones[11, 2] = "f(x)=x² + 2x³";
        ecuaciones[11, 3] = "f(x)=x³ + x²";

        ecuaciones[12, 0] = "f(x)=log(x)";
        ecuaciones[12, 1] = "f(x)=ln(x)";
        ecuaciones[12, 2] = "f(x)=log(x)+1";
        ecuaciones[12, 3] = "f(x)=log(x+1)";

        ecuaciones[13, 0] = "f(x)=log(x+2) + 2";
        ecuaciones[13, 1] = "f(x)=log(x+2)";
        ecuaciones[13, 2] = "f(x)=log(x) + 2";
        ecuaciones[13, 3] = "f(x)=ln(x) + 2";

        ecuaciones[14, 0] = "f(x)=log(x²)";
        ecuaciones[14, 1] = "f(x)=-x²";
        ecuaciones[14, 2] = "f(x)=log(-x) + log(x)";
        ecuaciones[14, 3] = "f(x)=2(log(x))";

        ecuaciones[15, 0] = "f(x)=ln(x)";
        ecuaciones[15, 1] = "f(x)=log(x)";
        ecuaciones[15, 2] = "f(x)=log(2x)";
        ecuaciones[15, 3] = "f(x)=log(x) + 1";

        ecuaciones[16, 0] = "f(x)=|x|";
        ecuaciones[16, 1] = "f(x)=x²";
        ecuaciones[16, 2] = "f(x)=-x + x";
        ecuaciones[16, 3] = "f(x)=-x²";

        ecuaciones[17, 0] = "f(x)=(x+1)² + x + 1";
        ecuaciones[17, 1] = "f(x)=x² - 1.5";
        ecuaciones[17, 2] = "f(x)=(x-1.5)²";
        ecuaciones[17, 3] = "f(x)=(x+1.5)²";

        ecuaciones[18, 0] = "f(x)=x² +4x +3";
        ecuaciones[18, 1] = "f(x)=(x+2)² ";
        ecuaciones[18, 2] = "f(x)=(x-1)²+2";
        ecuaciones[18, 3] = "f(x)=x² - x - 1";

        ecuaciones[19, 0] = "f(x)=x³ + 2x² - x - 2";
        ecuaciones[19, 1] = "f(x)=x³ - x² + x + 2";
        ecuaciones[19, 2] = "f(x)=x³ + x²";
        ecuaciones[19, 3] = "f(x)=x³ + 2x² + x";

    }

    public void ponerEcuacion(int x, bool cor)
    {
        if (cor)
        {
            pregunta.text = ecuaciones[x, 0];
        }
        else
        {
            int y = Random.Range(1, 4);

            pregunta.text = ecuaciones[x, y];
        }
    }


}
