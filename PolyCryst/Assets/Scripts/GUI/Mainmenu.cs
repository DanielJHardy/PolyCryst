using UnityEngine;
using System.Collections;

public class Mainmenu : MonoBehaviour 
{

	public Texture splash = null;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.anyKey) 
		{
			Application.LoadLevel (1);
		}
	}
	void OnGUI()
	{
		GUI.Label (new Rect (800, 60, 300, 20), "Press the any key");
		GUI.Label (new Rect (800, 90, 500, 20), "splash screen under construction");
	}
}
