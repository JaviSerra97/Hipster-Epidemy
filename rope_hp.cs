using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope_hp : MonoBehaviour {
	public static int hp;
	// Use this for initialization
	void Start () {
		hp = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (hp == 0) {
			Destroy (this.gameObject);
		}
	}
}
