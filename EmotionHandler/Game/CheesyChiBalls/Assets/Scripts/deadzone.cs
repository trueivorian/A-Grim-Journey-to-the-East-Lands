﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadzone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D target)
    {
        
        Debug.Log("Entering Deadzone");
        Destroy (target.gameObject);
    }
}
