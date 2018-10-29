using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

	// Use this for initialization

	// Update is called once per frame
	void Update () {
		
	}
	public void CargarNivel (string pNombreNivel){
		SceneManager.LoadScene (pNombreNivel);
	}
}

