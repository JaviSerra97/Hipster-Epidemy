using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_move : MonoBehaviour {
	public float limitup, limitdown;
	private int vely;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y >= limitup) {
			vely = -1;
		}
		if (transform.position.y <= limitdown) {
			vely = 1;
		}
		transform.Translate (new Vector2 (0, vely) * Time.deltaTime * 0.7f, Space.World);
	}
}