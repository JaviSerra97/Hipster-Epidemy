 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_movement : MonoBehaviour {
	private Animator anim;
	public bool grounded;
	private Rigidbody2D myriggi;
	public GameObject bullet;
	private Vector3 bullet_posi;
	public bool walk;
	public static int coffe, lifes;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		myriggi = GetComponent<Rigidbody2D> ();
		coffe = 10;
		walk = true;
		lifes = 3;
	}
	
	// Update is called once per frame
	void Update () {		
		anim.SetBool ("walk", false);
		anim.SetBool ("fire", false);
		anim.SetBool ("jump", false);
		anim.SetBool ("ground", true);
		Right ();
		Left ();
		JumpAnim ();
		FireAnim ();
		GroundCheck ();
		Death ();
	}

	public void Right(){
		if (Input.GetAxisRaw("Horizontal") > 0 && walk) {
			transform.Translate (Vector2.right * Time.deltaTime*2, Space.World);
			transform.eulerAngles = new Vector2 (0, 0);
			anim.SetBool ("walk", true);
		}
	}

	public void Left(){
		if (Input.GetAxisRaw("Horizontal") < 0 && walk) {
			transform.Translate (Vector2.left * Time.deltaTime*2, Space.World);
			transform.eulerAngles = new Vector2 (0, 180);
			anim.SetBool ("walk", true);
		}
	}

	public void JumpAnim(){
		if (Input.GetAxisRaw ("Jump") > 0 && grounded && myriggi.velocity.y <= 0) {
			anim.SetBool ("jump", true);
		}
	}

	public void Jump(){
			myriggi.velocity += new Vector2 (0, 7);
	}

	public void FireAnim(){
		if (Input.GetButtonDown ("Fire1") && coffe>0) {
			anim.SetBool ("fire", true);
		}
	}

	public void Fire(){
		bullet_posi = transform.position + new Vector3 (0.3f, -0.3f, 0);
		Instantiate (bullet, bullet_posi, transform.rotation);
		coffe--;
		}


	public void Walk(){
		if (grounded) {
			walk = true;
		}
	}

	public void NoWalk(){
		if (grounded) {
			walk = false;
		}
	}

	public void GroundCheck(){
		if (grounded) {
			anim.SetBool ("ground", true);
		} else {
			anim.SetBool ("ground", false);
		}
	}

	public void Death(){
		if (lifes == 0) {
			SceneManager.LoadScene ("game_over");
		}
	}

	void OnTriggerEnter2D(Collider2D item){
		if (item.gameObject.tag == "Coffe") {
			coffe = 10;
			Destroy (item.gameObject);
		}
		if (item.gameObject.tag == "Enemy" && lifes>0) {
			lifes--;
		}
		if (item.gameObject.tag == "Enemy2" && lifes>0) {
			lifes--;
		}
		if (item.gameObject.tag == "Enemy3" && lifes>0) {
			lifes--;
		}
		if (item.gameObject.tag == "Enemy4" && lifes>0) {
			lifes--;
		}
		if (item.gameObject.tag == "Enemy5" && lifes>0) {
			lifes--;
		}
		if (item.gameObject.tag == "Enemy6" && lifes>0) {
			lifes--;
		}
		if (item.gameObject.tag == "Enemy7" && lifes>0) {
			lifes--;
		}
		if (item.gameObject.tag == "Enemy8" && lifes>0) {
			lifes--;
		}
		if (item.gameObject.tag == "Finisher") {
			lifes=0;
		}
		if (item.gameObject.tag == "Pass") {
			SceneManager.LoadScene ("lv2");
		}
	}

	void OnCollisionStay2D (Collision2D coll){
		if (coll.gameObject.tag == "Ground") {
			transform.parent = coll.transform;
			grounded = true;
		}
	}

	void OnCollisionExit2D (Collision2D coll){
		if (coll.gameObject.tag == "Ground") {
			transform.parent = null;
			grounded = false;
		}
	}
}

