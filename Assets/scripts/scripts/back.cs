using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
    public string level = "test_scene";
    public Transform warpTarget;

    // Use this for initialization
    IEnumerator OnTriggerEnter2D(Collider2D Colider)
    {
        fading f = GameObject.FindGameObjectWithTag("Fader").GetComponent<fading>();

        yield return StartCoroutine(f.fadeToBlack());

        if (Colider.gameObject.tag == "Player")
            SceneManager.LoadScene(level);
        Debug.Log("its Colliding!");
    }
}