using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medalla : MonoBehaviour {

    public string completed;

	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt(completed) > 0)
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
        }
	}
}
