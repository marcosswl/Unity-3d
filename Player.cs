using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float VelAnda = 10;
	public bool Andando;
	void Start () {

	}

	void Update () {
		//Aceleraçao ao correr (shift)
		if(Input.GetKey (KeyCode.LeftShift) && VelAnda <= 15){
			VelAnda += 0.5f;
		}
		//Desaceleração também
		else if(!Input.GetKey (KeyCode.LeftShift) && VelAnda > 10){
			VelAnda -= 0.5f;
		}
		/*******************************
		Movimentos basicos
		transform.translate = muda a posição do objeto
		time.deltatime = faz com que a velocidade dependa do tempo (m/s) e não dos FPS, 
		já que o Void update() executa a cada quadro.
		********************* *********/
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
