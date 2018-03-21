using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {

    public bool isGrabbed = false;
    public string itemName = "";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool getGrabbed()
    {
        return isGrabbed;
    }
}
