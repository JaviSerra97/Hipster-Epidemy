using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life_text : MonoBehaviour {
	Text txtLifes;
	// Use this for initialization
	void Start () {
		txtLifes = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		txtLifes.text = "X " + player_movement.lifes.ToString () ;
	}
}
