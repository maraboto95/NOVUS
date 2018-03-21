using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespuestaScript_Pendiente : MonoBehaviour {

    public TextMesh RespuestaTextMesh;

  


    // Use this for initialization
    void Awake()
    {
        RespuestaTextMesh = this.gameObject.GetComponent<TextMesh>();



    }

    // Update is called once per frame
    void Update()
    {

    }
}
