using UnityEngine;
using System.Collections;

public class EndScreen : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnGUI()
	{
		GUI.Label (new Rect (790, 40, 100, 100), "Congratulations!");
		GUI.Label (new Rect (790, 100, 120, 100), "Special Thanks To");
		GUI.Label (new Rect (790, 140, 100, 100), "Karel Chabera");
		GUI.Label (new Rect (790, 155, 100, 100), "Alex Carlyle");
		GUI.Label (new Rect (790, 170, 100, 100), "Manny Vaccaro");
		GUI.Label (new Rect (790, 185, 100, 100), "Mark Davies");
		GUI.Label (new Rect (790, 215, 100, 100), "And You!");
		GUI.Label (new Rect (790, 230, 140, 100), "Thanks for Playing!");

		if(GUI.Button(new Rect(800,300,80,20), "Play Again")) 
		{
			Application.LoadLevel(0);
		}
		if(GUI.Button(new Rect(800,330,80,20), "Exit")) 
		{
			Application.Quit();
		}
	}
}
