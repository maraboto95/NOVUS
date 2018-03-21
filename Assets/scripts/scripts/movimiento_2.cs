using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_2 : MonoBehaviour {

    public float speed = 1.5f;
    private Animator animator;
    public string[] inventory = new string[10];
    public bool nable;
    public int vida;

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
        vida = 3;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GameObject.FindGameObjectWithTag("malo").GetComponent<malo>().end == false)
        {
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

            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (Input.GetKey(KeyCode.UpArrow))
                if (nable == true)
                {
                    rb.AddForce(new Vector2(0, 100));
                }
        }
    }

    void OnCollisionEnter2D(Collision2D loc)
    {
        if(loc.gameObject.tag == "malo")
        {
            nable = true;
        }
    }
}
