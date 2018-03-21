using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class malo : MonoBehaviour {

    public Transform weak;
    public float height;
    public bool rebota, end;
    public int malavida;
    public Text mal, bien;
    public Image m1, m2, m3, m4, m5, m6, b1, b2, b3;
    public float timeToChange;


    // Use this for initialization
    void Start()
    {
        malavida = 6;
        mal.text = malavida.ToString();
        bien.text = GameObject.FindGameObjectWithTag("Player").GetComponent<movimiento_2>().vida.ToString();
        timeToChange = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(end == false)
        {
            if (rebota == false)
            {
                transform.position += Vector3.left * 6f * Time.deltaTime;
            }
            else
            {
                transform.position += Vector3.right * 6f * Time.deltaTime;
            }

            mal.text = malavida.ToString();
            bien.text = GameObject.FindGameObjectWithTag("Player").GetComponent<movimiento_2>().vida.ToString();

            if (malavida == 0 || GameObject.FindGameObjectWithTag("Player").GetComponent<movimiento_2>().vida == 0)
            {
                end = true;
            }

            if (malavida < 6)
            {
                m1.color = new Color(0, 0, 0, 0);
            }

            if (malavida < 5)
            {
                m2.color = new Color(0, 0, 0, 0);
            }

            if (malavida < 4)
            {
                m3.color = new Color(0, 0, 0, 0);
            }

            if (malavida < 3)
            {
                m4.color = new Color(0, 0, 0, 0);
            }

            if (malavida < 2)
            {
                m5.color = new Color(0, 0, 0, 0);
            }

            if (malavida < 1)
            {
                m6.color = new Color(0, 0, 0, 0);
            }

            if(GameObject.FindGameObjectWithTag("Player").GetComponent<movimiento_2>().vida < 3)
            {
                b1.color = new Color(0, 0, 0, 0);
            }

            if (GameObject.FindGameObjectWithTag("Player").GetComponent<movimiento_2>().vida < 2)
            {
                b2.color = new Color(0, 0, 0, 0);
            }

            if (GameObject.FindGameObjectWithTag("Player").GetComponent<movimiento_2>().vida < 1)
            {
                b3.color = new Color(0, 0, 0, 0);
            }
        }
        else
        {
            if(malavida <= 0)
            {
                timeToChange -= Time.deltaTime;
                if (timeToChange <= 0)
                {
                    SceneManager.LoadScene("cueva");
                }
            }
            else
            {
                if(GameObject.FindGameObjectWithTag("Player").GetComponent<movimiento_2>().vida == 0)
                {
                    timeToChange -= Time.deltaTime;
                    if (timeToChange <= 0)
                    {
                        SceneManager.LoadScene("batalla");
                    }
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            height = col.contacts[0].point.y - weak.position.y;

            if (height > 0)
            {
                col.rigidbody.AddForce(new Vector2(0, 1000));
                malavida--;
            }
            else
            {
                col.rigidbody.AddForce(new Vector2(0, 1000));
                col.gameObject.GetComponent<movimiento_2>().vida--;
            }
        }
        else
        {
            if (col.gameObject.tag != "piso")
            {
                if (rebota == true)
                {
                    rebota = false;
                }
                else {
                    rebota = true;
                }
            }
        }
    }
}
