﻿using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public float timer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer = 1*Time.deltaTime;
	}
}