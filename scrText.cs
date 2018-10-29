using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrText : MonoBehaviour {
	Text txtMunicion;
	// Use this for initialization
	void Start () {
		txtMunicion = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		txtMunicion.text = "X " + player_movement.coffe.ToString () + "L";
	}
}
