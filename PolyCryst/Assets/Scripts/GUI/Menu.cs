using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.LoadLevel(0);
		}
		if (Input.GetKey(KeyCode.Alpha1))
		{
			Application.LoadLevel(2);
		}
		if (Input.GetKey(KeyCode.Alpha2))
		{
			Application.LoadLevel(3);
		}
		if (Input.GetKey(KeyCode.Alpha3))
		{
			Application.LoadLevel(4);
		}
		if (Input.GetKey(KeyCode.Alpha4))
		{
			Application.LoadLevel(5);
		}
		if (Input.GetKey(KeyCode.Alpha5))
		{
			Application.LoadLevel(6);
		}
		if (Input.GetKey(KeyCode.Alpha6))
		{
			Application.LoadLevel(7);
		}
		if (Input.GetKey(KeyCode.Alpha7))
		{
			Application.LoadLevel(8);
		}
		if (Input.GetKey(KeyCode.Alpha8))
		{
			Application.LoadLevel(9);
		}
		if (Input.GetKey(KeyCode.Alpha9))
		{
			Application.LoadLevel(10);
		}
		if (Input.GetKey(KeyCode.Alpha0))
		{
			Application.LoadLevel(11);
		}
	}

	void OnGUI()
	{
		GUI.Box (new Rect (790, 40, 100, 360), "Level Select");

		if(GUI.Button(new Rect(800,60,80,20), "Title Screen")) 
		{
			Application.LoadLevel(0);
		}

		if(GUI.Button(new Rect(800,90,80,20), "Level 1")) 
		{
			Application.LoadLevel(2);
		}

		if(GUI.Button(new Rect(800,120,80,20), "Level 2")) 
		{
			Application.LoadLevel(3);
		}
		if(GUI.Button(new Rect(800,150,80,20), "Level 3")) 
		{
			Application.LoadLevel(4);
		}
		if(GUI.Button(new Rect(800,180,80,20), "Level 4")) 
		{
			Application.LoadLevel(5);
		}
		if(GUI.Button(new Rect(800,210,80,20), "Level 5")) 
		{
			Application.LoadLevel(6);
		}
		if(GUI.Button(new Rect(800,240,80,20), "Level 6")) 
		{
			Application.LoadLevel(7);
		}
		if(GUI.Button(new Rect(800,270,80,20), "Level 7")) 
		{
			Application.LoadLevel(8);
		}
		if(GUI.Button(new Rect(800,300,80,20), "Level 8")) 
		{
			Application.LoadLevel(9);
		}
		if(GUI.Button(new Rect(800,330,80,20), "Level 9")) 
		{
			Application.LoadLevel(10);
		}
		if(GUI.Button(new Rect(800,360,80,20), "Level 10")) 
		{
			Application.LoadLevel(11);
		}
		if(GUI.Button(new Rect(20,1000,80,20), "Exit")) 
		{
			Application.Quit();
		}
	}
}