using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boss_scr : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D item){
		if (item.gameObject.tag == "Boss") {
			Destroy (item.gameObject);
		}
		if (item.gameObject.tag == "GameOver") {
			SceneManager.LoadScene ("game_over");
		}
	}
}
