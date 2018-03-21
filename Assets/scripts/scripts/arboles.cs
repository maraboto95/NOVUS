using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arboles : MonoBehaviour {

    public SpriteRenderer i;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerStay2D(Collider2D Colider)
    {
        if (Colider.gameObject.tag == "Player")
        {
            i.color = new Color(255, 255, 255, 0.5f);
        }   
    }

    void OnTriggerExit2D(Collider2D Colider)
    {
        if (Colider.gameObject.tag == "Player")
        {
            i.color = new Color(255, 255, 255, 1);
        }
    }
}
