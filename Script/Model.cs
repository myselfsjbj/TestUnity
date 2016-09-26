using UnityEngine;
using System.Collections;
using System;
public class Model : MonoBehaviour {
	private int hp;
	public event EventHandler HPADD;
	public int HP{
		get{ return hp;}
		set{ 
			hp += value;
			if (HPADD != null) {
				HPADD (this, new EventArgs ());
			}
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
