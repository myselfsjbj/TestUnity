using UnityEngine;
using System.Collections;

public class InitController : MonoBehaviour {
	Controllerr ctr;
	// Use this for initialization
	void Start () {
		ctr = new Controllerr ();
		Invoke ("hide", 5);
	}
	void hide(){
		ctr.hide();
	}
	void show(){
		ctr.show();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
