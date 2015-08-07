using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour 
{
	public float jumPower = 10 ;
	public bool isGrounded = false;
	public AudioClip otherClip = null;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if ((Input.GetKeyDown (KeyCode.Space) && isGrounded == true) || (Input.GetKeyDown (KeyCode.UpArrow) && isGrounded == true )) 
		{
			GetComponent<Rigidbody>().AddForce(Camera.main.transform.up * jumPower, ForceMode.Impulse);
		}
	}

	void OnCollisionStay(Collision other)
	{
		isGrounded = true;
	}
	void OnCollisionExit(Collision other)
	{
		isGrounded = false;
	}
}
