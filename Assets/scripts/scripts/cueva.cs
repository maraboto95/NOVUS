using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cueva : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0.5f);
        }
    }

    void OnTriggerExit2D(Collider2D col2)
    {
        if (col2.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
        }
    }
}
