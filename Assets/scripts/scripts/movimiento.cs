using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movimiento : MonoBehaviour {

    public float speed = 1.5f;
    private Animator animator;
    public string[] inventory = new string[10];
    public Button b;
    private float timeToChange;
    private bool ready;

	// Use this for initialization
	void Start () {
        animator = this.GetComponent<Animator>();
        timeToChange = 2;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if(SceneManager.GetActiveScene().name == "test_scene")
        {
            b.onClick.AddListener(taskOnBatalla);
        } 

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetInteger("direction", 1);
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.speed = 1;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            {

            }
            else
            {
                animator.speed = 0;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetInteger("direction", 3);
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.speed = 1;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            {

            }
            else
            {
                animator.speed = 0;
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetInteger("direction", 2);
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.speed = 1;
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {

            }
            else
            {
                animator.speed = 0;
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetInteger("direction", 0);
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.speed = 1;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
            {

            }
            else
            {
                animator.speed = 0;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetInteger("direction", 4);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetInteger("direction", 5);
        }

        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetInteger("direction", 7);
        }

        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetInteger("direction", 6);
        }

        /*if (GameObject.FindGameObjectWithTag("Item").GetComponent<item>().getGrabbed() == true)
        {
            inventory[0] = GameObject.FindGameObjectWithTag("Item").GetComponent<item>().itemName;
        }*/

        if(PlayerPrefs.GetInt("tabla") == 1 && PlayerPrefs.GetInt("tabla2") == 1 && PlayerPrefs.GetInt("funcrel") == 1 && PlayerPrefs.GetInt("domran") == 1 && PlayerPrefs.GetInt("particulas") == 1)
        {
            GameObject.Find("limite-norte").GetComponent<BoxCollider2D>().isTrigger = true;
        }

        if(ready == true)
        {
            timeToChange -= Time.deltaTime;
            if (timeToChange <= 0)
            {
                SceneManager.LoadScene("batalla");
            }
        }
    }

    void taskOnBatalla()
    {
        ready = true;
    }
}
