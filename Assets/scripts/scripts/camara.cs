﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour {

    private Transform player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("principal").transform;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 playerpos = player.position;
        playerpos.z = transform.position.z;
        transform.position = playerpos;
	}
}
