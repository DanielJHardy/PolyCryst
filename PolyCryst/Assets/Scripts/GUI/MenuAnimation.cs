using UnityEngine;
using System.Collections;

public class MenuAnimation : MonoBehaviour 
{
	public Transform[] target = null;


	void OnTriggerStay(Collider other)
	{
		if (target.Length > 0 && other.tag == "Player")
		{
			int i = Random.Range (0, target.Length);
			other.transform.position = target [i].position;
			other.GetComponent<Rigidbody>().AddForce (Vector3.up, ForceMode.Impulse);
		}
	}
}