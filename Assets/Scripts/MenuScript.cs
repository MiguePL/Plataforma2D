 using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Animator))]
public class MenuScript : MonoBehaviour {
	Animator anim;
	private bool menu_pausa = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (menu_pausa) {
				continuar ();
			} else
				pausa ();
		}
	}

	public void pausa(){
		menu_pausa = true;
		anim.SetBool ("opciones", false);
		anim.SetBool ("pausa", true);
	}

	public void salir(){
		Application.Quit ();
		Debug.Log ("Saliendo");
	}

	public void opciones(){
		anim.SetBool ("opciones", true);
		anim.SetBool ("pausa", true);
	}

	public void continuar(){
		menu_pausa = false;
		anim.SetBool ("opciones", false);
		anim.SetBool ("pausa", false);

	}
}
