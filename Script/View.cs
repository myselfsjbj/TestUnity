using UnityEngine;
using System.Collections;
using System;
public class View : MonoBehaviour {
	public UILabel hl;
	public UIButton ab;
	public string Text{
		get{ return hl.text;}
		set{ hl.text = value;}
	}
	public event EventHandler OnClick;
	public void btnClicked(){
		if (OnClick != null) {
			OnClick (this, new EventArgs ());

		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
