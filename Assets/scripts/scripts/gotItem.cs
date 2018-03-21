using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotItem : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D Collider)
    {

        item i = GameObject.FindGameObjectWithTag("Item").GetComponent<item>();
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        if (Collider.gameObject.tag == "Player")
        {
            renderer.color = new Color(0, 0, 0, 0);
            i.isGrabbed = true;
        }
    }
}
