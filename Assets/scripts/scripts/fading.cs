using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fading : MonoBehaviour {

    Animator anim;
    bool isFading = false;
        
        // Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator fadeToClear()
    {
        isFading = true;
        anim.SetTrigger("fadein");

        while (isFading)
        {
            yield return null;
        }
    }

    public IEnumerator fadeToBlack()
    {
        isFading = true;
        anim.SetTrigger("fadeout");

        while (isFading)
        {
            yield return null;
        }
    }

    void animationComplete()
    {
        isFading = false;
    }
}
