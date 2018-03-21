using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class final_medalla : MonoBehaviour {

    public string level;
    public int id;

    // Use this for initialization

    void Start()
    {
        level = "pelea2";
    }
    IEnumerator OnTriggerEnter2D(Collider2D Colider)
    {
        if (PlayerPrefs.GetInt("bolas") == 1 && PlayerPrefs.GetInt("enlaces") == 1 && PlayerPrefs.GetInt("funciones") == 1 && PlayerPrefs.GetInt("graficas") == 1 && PlayerPrefs.GetInt("grafno") == 1 && PlayerPrefs.GetInt("metal") == 1 && PlayerPrefs.GetInt("pendiente") == 1)
        {
            fading f = GameObject.FindGameObjectWithTag("Fader").GetComponent<fading>();

            yield return StartCoroutine(f.fadeToBlack());

            if (Colider.gameObject.tag == "Player")
            {
                if (SceneManager.GetActiveScene().name == "cuarto")
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
}
