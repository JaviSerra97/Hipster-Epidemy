using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class photo_change : MonoBehaviour {
	public RawImage image;
	public Texture2D life_03;
	public Texture2D life_02;
	public Texture2D life_01;
	public Texture2D life_00;

	// Use this for initialization
	void Start () {
		image = GetComponent<RawImage> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (player_movement.lifes == 3) {
			image.texture = life_03;
		}
		if (player_movement.lifes == 2) {
			image.texture = life_02;
		}
		if (player_movement.lifes == 1) {
			image.texture = life_01;
		}
		if (player_movement.lifes == 0) {
			image.texture = life_00;
		}
	}
}
