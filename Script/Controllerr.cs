using UnityEngine;
using System.Collections;
using System;
public class Controllerr  {
	Model currentModel;
	View currentView;
	// Use this for initialization
	public Controllerr()
	{
		currentView = GameObject.Find ("MainGUI").GetComponent<View> ();
		currentModel = new Model ();
		currentModel.HPADD+=updateLabel;
		currentModel.HPADD+=(s,e)=>Debug.Log("hhhhhhh");
		currentView.OnClick += (s, e) => {
			currentModel.HP=50;
		};
		updateLabel(null,null);
	}
	void updateLabel(object sender,EventArgs arg)
	{
		currentView.Text=System.Convert.ToString(currentModel.HP);
	}
	public void show(){
		currentView.gameObject.SetActive(true);
	}
	public void hide(){
		currentView.gameObject.SetActive(false);
	}

}
