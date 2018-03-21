using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class regresar : MonoBehaviour {

    public Button regresara;
    public bool clicked;
    public float timeToChange;

	// Use this for initialization
	void Start () {
        clicked = false;
        timeToChange = 2f;
	}
	
	// Update is called once per frame
	void Update () {
        regresara.onClick.AddListener(taskOnChange);

        if (clicked)
        {
            timeToChange -= Time.deltaTime;

            if (timeToChange <= 0)
            {
                taskOnRegresar();
            }
        }
	}

    void taskOnChange()
    {
        clicked = true;
    }

    void taskOnRegresar()
    {
        SceneManager.LoadScene("cueva");
    }
}
