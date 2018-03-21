using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class transition : MonoBehaviour
{
    public string level;
    public int id;

    // Use this for initialization

    void Start()
    {
        switch (PlayerPrefs.GetInt("nivel"))
        {
            case 1: level = "juego_tabla";
                break;
            case 2: level = "juego_tabla2";
                break;
            case 3: level = "juego_graficas";
                break;
            case 4: level = "juego_dr";
                break;
            case 5: level = "juego_particulas";
                break;
            case 6:
                level = "bolas";
                break;
            case 7:
                level = "enlaces";
                break;
            case 8:
                level = "funciones";
                break;
            case 9:
                level = "graficas";
                break;
            case 10:
                level = "graphicornot";
                break;
            case 11:
                level = "MetalONoMetal";
                break;
            case 12:
                level = "pelea1";
                break;
            case 13:
                level = "pelea2";
                break;
            case 14:
                level = "Pendiente";
                break;
        }
    }
    IEnumerator OnTriggerEnter2D(Collider2D Colider)
    {
        fading f = GameObject.FindGameObjectWithTag("Fader").GetComponent<fading>();

        yield return StartCoroutine(f.fadeToBlack());

        if (Colider.gameObject.tag == "Player")
        {
            if(SceneManager.GetActiveScene().name == "cuarto")
            {
                SceneManager.LoadScene(level);
            }
            else
            {
                PlayerPrefs.SetInt("nivel", id);
                SceneManager.LoadScene("cuarto");
            }
        }

        Debug.Log("its Colliding!"); 
    }
}