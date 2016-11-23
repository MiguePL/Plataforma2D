using UnityEngine;
using System.Collections;

public class GeneradorMonedas : MonoBehaviour {
	private GameObject moneda_nueva;
	public Transform pos_salida;
	public GameObject [] monedas;
	private int numero_moneda = 0;
	Animator anim;

	void Start(){
		pos_salida = transform.Find ("posicion_salida").transform;
		Debug.Log ("Cantidad de monedas: " + monedas.Length);
		anim = GetComponent<Animator> ();
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player" ) {
			numero_moneda = Random.Range (0, monedas.Length - 1);
			moneda_nueva = (GameObject)Instantiate (monedas[numero_moneda], pos_salida.position, transform.rotation);
			anim.SetTrigger ("bote");
		}
	}
	void OnTriggerEnter2D(Collider2D objeto){
		if(objeto.tag == "Player" && moneda_nueva == null) {
			moneda_nueva = (GameObject)Instantiate (monedas[numero_moneda], transform.position, transform.rotation);
		}
	}
}