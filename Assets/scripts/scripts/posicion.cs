using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class posicion : MonoBehaviour
{

    void Start()
    {
        PlayerPrefs.SetFloat("x", -14);
        PlayerPrefs.SetFloat("y", -8);
        if (SceneManager.GetActiveScene().name == "test_scene")
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("x", -11)+2, PlayerPrefs.GetFloat("y", 0)-2, PlayerPrefs.GetFloat("z", 5));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "test_scene")
        {
            PlayerPrefs.SetFloat("x", transform.position.x);
            PlayerPrefs.SetFloat("y", transform.position.y);
            PlayerPrefs.SetFloat("z", transform.position.z);
        }
    }
}