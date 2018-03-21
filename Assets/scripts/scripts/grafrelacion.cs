using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class grafrelacion : MonoBehaviour
{

    public Button b;
    public float speed = 1.5f;
    public bool correct, direccion, fail, ready;
    private int x;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (fail == false)
        {
            if (correct == false)
            {
                b.onClick.AddListener(taskOnClick);
                if (GetComponent<RectTransform>().transform.position.x < -50)
                {
                    direccion = false;
                }

                if (GetComponent<RectTransform>().transform.position.x > 1400)
                {
                    direccion = true;
                }

                if (direccion == false)
                {
                    GetComponent<RectTransform>().transform.position += Vector3.right * speed * Time.deltaTime;
                }
                else
                {
                    GetComponent<RectTransform>().transform.position += Vector3.left * speed * Time.deltaTime;
                }
            }
        }
        else
        {
            GetComponent<Image>().color = new Color(255, 0, 0);
            GetComponent<Button>().interactable = false;
        }
    }

    void taskOnClick()
    {
        if (GameObject.FindGameObjectWithTag("Decision").GetComponent<seleccion_fr>().selectedr == true && ready == false)
        {
            GetComponent<RectTransform>().transform.position = new Vector3(-440, 150, 0);
            correct = true;
            ready = true;
            x = PlayerPrefs.GetInt("puntos");
            x++;
            PlayerPrefs.SetInt("puntos", x);
        }
        else
        {
            fail = true;
        }
    }
}
