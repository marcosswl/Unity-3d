using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float VelAnda = 10;
	public bool Andando;
	void Start () {

	}

	void Update () {
		//Detecta Quando esta andando
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.D)) {
			Andando = true;
		} 
		else {
			Andando = false;
		}
		//Aceleraçao ao correr (shift)
		if(Input.GetKey (KeyCode.LeftShift) && VelAnda <= 15){
			VelAnda += 0.5f;
		}
		else if(!Input.GetKey (KeyCode.LeftShift) && VelAnda > 10){
			VelAnda -= 0.5f;
		}
		//Movimentos basicos
		    if (Input.GetKey (KeyCode.W)) {
			transform.Translate(0,0,VelAnda*Time.deltaTime);
		}
		    if (Input.GetKey (KeyCode.S)) {
			transform.Translate(0,0,-VelAnda*Time.deltaTime);
		}
		    if (Input.GetKey (KeyCode.A)) {
			transform.Translate(-VelAnda*Time.deltaTime,0,0);
		}
			if (Input.GetKey (KeyCode.D)) {
			transform.Translate (VelAnda * Time.deltaTime, 0, 0);
		}
	}
}
