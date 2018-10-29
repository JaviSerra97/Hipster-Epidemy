using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {
	float lifeTime = 0.8f; 
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.right*Time.deltaTime*15);
		Destroy(gameObject, lifeTime);
	}
	void OnTriggerEnter2D(Collider2D item){
		if (item.gameObject.tag == "Rope") {
			rope_hp.hp--;
			Destroy (this.gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Ground") {
			Destroy (this.gameObject);
		}
	}

}