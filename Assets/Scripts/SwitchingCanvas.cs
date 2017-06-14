﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchingCanvas : MonoBehaviour {

    public Canvas myCanvas;
    public Canvas nextCanvas;
    public Canvas lastCanvas;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    public void changeCanvasProperty()
    {
        myCanvas.gameObject.SetActive(!myCanvas.gameObject.activeSelf);
        nextCanvas.gameObject.SetActive(!nextCanvas.gameObject.activeSelf);
    }
}
