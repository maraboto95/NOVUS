using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript_graficas : MonoBehaviour {

    public static PlayerScript_graficas script;

    public Sprite uno;
    public Sprite dos;
    public Sprite tre;
    public Sprite cua;
    public Sprite cin;
    public Sprite sei;

    public int sprite;



	void Awake () {
        script = this;
	}
	

    void changeSprite()
    {
        switch (sprite)
        {
            case 0:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = uno;

                break;
            case 1:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = dos;
                break;
            case 2:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = tre;
                break;
            case 3:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = cua;
                break;
            case 4:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = cin;
                break;
            case 5:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sei;
                break;
        }
    }

    public void subirSprite()
    {
        sprite++;
        changeSprite();
    }
}
