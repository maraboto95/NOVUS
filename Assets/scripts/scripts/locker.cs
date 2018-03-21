using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class locker : MonoBehaviour
{

    public string level = "shack";
    public string itemNeeded = "key";

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator OnTriggerEnter2D(Collider2D Collider)
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<movimiento>().inventory[0] == itemNeeded)
        {
            fading f = GameObject.FindGameObjectWithTag("Fader").GetComponent<fading>();

            yield return StartCoroutine(f.fadeToBlack());

            if (Collider.gameObject.tag == "Player")
                SceneManager.LoadScene(level);
            Debug.Log("its Colliding!");
        }
    }
}
