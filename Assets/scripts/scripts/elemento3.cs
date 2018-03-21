using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class elemento3 : MonoBehaviour
{

    public bool isCorrect;
    public int atomic;
    public bool isReady = false;
    public InputField inp;
    public Text eleText, randoms;
    public Button b;
    public string symbol;

    // Use this for initialization
    void Start()
    {
        inp.GetComponent<InputField>();
        eleText.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if(inp.text.ToLower() == randoms.text && eleText.text.ToLower() == randoms.text)
        {
            isReady = true;
            b.onClick.AddListener(taskOnClick);
        }
        else
        {
            isReady = false;
        }
    }

    void taskOnClick()
    {
        isCorrect = true;
        eleText.color = new Color(0, 0, 0, 1);
        roll();
        inp.text = "";
    }

    public void roll()
    {
        inp.GetComponent<tabla2>().r = Random.Range(0, inp.GetComponent<tabla2>().elementos.Length);
        inp.GetComponent<tabla2>().random.text = inp.GetComponent<tabla2>().elementos[inp.GetComponent<tabla2>().r].name;
        inp.GetComponent<tabla2>().randoms.text = inp.GetComponent<tabla2>().elementos[inp.GetComponent<tabla2>().r].GetComponent<elemento3>().symbol;
        while (inp.GetComponent<tabla2>().elementos[inp.GetComponent<tabla2>().r].GetComponent<elemento3>().isCorrect == true)
        {
            inp.GetComponent<tabla2>().r = Random.Range(0, inp.GetComponent<tabla2>().elementos.Length);
            inp.GetComponent<tabla2>().random.text = inp.GetComponent<tabla2>().elementos[inp.GetComponent<tabla2>().r].name;
            inp.GetComponent<tabla2>().randoms.text = inp.GetComponent<tabla2>().elementos[inp.GetComponent<tabla2>().r].GetComponent<elemento3>().symbol;
        }
    }
}
