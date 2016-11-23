using UnityEngine;
using System.Collections;

public class Moneda : MonoBehaviour {
	private Rigidbody2D rb;
	GameObject txt_moneda;
	ControlMonedas ctrl_moneda; 
	public int valor;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (new Vector2(Random.Range(-20,20),20));
		txt_moneda = GameObject.Find ("texto_moneda");
		ctrl_moneda = txt_moneda.GetComponent<ControlMonedas> ();
		Destroy (gameObject,600);

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
			ctrl_moneda.suma_monedas (valor);
			Random.Range (0,0);

		}
	}
}