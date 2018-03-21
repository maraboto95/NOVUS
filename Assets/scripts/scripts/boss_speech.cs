using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss_speech : MonoBehaviour {

    public SpriteRenderer box, face;
    public MeshRenderer texto;
    public Button b;
    public Text t;

    // Use this for initialization
    void Start()
    {
        box.color = new Color(0, 0, 0, 0);
        face.color = new Color(0, 0, 0, 0);
        texto.material.color = new Color(0, 0, 0, 0);
        b.image.color = new Color(0, 0, 0, 0);
        t.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D Colider)
    {
        if (Colider.gameObject.tag == "Player")
        {
            box.color = new Color(255, 255, 255, 1);
            face.color = new Color(255, 255, 255, 1);
            texto.material.color = new Color(255, 255, 255, 1);
            b.image.color = new Color(255, 255, 255, 1);
            t.color = new Color(0, 0, 0, 1);
        }
    }

    void OnTriggerExit2D(Collider2D Colider)
    {
        if (Colider.gameObject.tag == "Player")
        {
            box.color = new Color(255, 255, 255, 0);
            face.color = new Color(255, 255, 255, 0);
            texto.material.color = new Color(255, 255, 255, 0);
            b.image.color = new Color(255, 255, 255, 0);
            t.color = new Color(255, 255, 255, 0);
        }
    }
}
