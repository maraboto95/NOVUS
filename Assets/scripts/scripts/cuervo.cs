using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuervo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D Colider)
    {
        if (Colider.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
        }
    }

    void OnTriggerExit2D(Collider2D Colider)
    {
        if (Colider.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
        }
    }
}
