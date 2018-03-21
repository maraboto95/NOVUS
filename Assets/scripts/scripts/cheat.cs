using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cheat : MonoBehaviour {

    public Button b;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        b.onClick.AddListener(completeGame);
    }

    void completeGame()
    {
        PlayerPrefs.SetInt("tabla", 1);
        PlayerPrefs.SetInt("tabla2", 1);
        PlayerPrefs.SetInt("funcrel", 1);
        PlayerPrefs.SetInt("domran", 1);
        PlayerPrefs.SetInt("particulas", 1);
    }
}
