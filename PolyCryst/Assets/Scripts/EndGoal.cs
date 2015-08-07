using UnityEngine;
using System.Collections;

public class EndGoal : MonoBehaviour 
{
	private float timer = 3;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player") 
		{
			timer -= Time.deltaTime;
			if(timer <1)
			{
				int i = Application.loadedLevel;
				Application.LoadLevel (i + 1);
			}
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") 
		{
			timer = 3;
		}
	}
}
