﻿using UnityEngine;
using System.Collections;

public class PlayerOverall : MonoBehaviour 
{

    private GameObject gameManager;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.LoadLevel(1);
		}

	}
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "KillBox") 
		{

            gameManager.GetComponent<GameManager>().playerDeath();

            Destroy(gameObject);
		
		}
	}

}
 