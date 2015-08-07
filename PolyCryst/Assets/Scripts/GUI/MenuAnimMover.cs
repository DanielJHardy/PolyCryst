using UnityEngine;
using System.Collections;

public class MenuAnimMover : MonoBehaviour {

	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		rb.velocity = new Vector3 (0, -5, 0);
	}
}
