using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PasarNivelScript : MonoBehaviour
{
    public static PasarNivelScript script;
    public GUIStyle myGUIStyle;

    string mensaje;

    void Awake()
    {
        script = this;
        myGUIStyle.fontSize = 40;

        mensaje = "";


    }

    public void GanoPerd(bool gano, string nivel)
    {
        StartCoroutine(IEnumNivel(gano, nivel));
    }


    public IEnumerator IEnumNivel(bool gano, string nivel)
    {

        if (gano)
        {
            PlayerPrefs.SetInt(nivel, 1);
            mensaje = "Felicidades! Nivel Completado!";
        }
        else
        {
            mensaje = "Nivel Fallido :( ¿Intentar de nuevo?";

        }


        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("cueva");

    }


    void OnGUI()
    {
        myGUIStyle.normal.textColor = Color.red;

        GUI.Label(new Rect(60, 100, 100, 20), mensaje, myGUIStyle);

           
    }
}