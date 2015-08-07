using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{

    public GameObject target;
    public float cam_distance = 10;

	void FixedUpdate()
	{
        if (target != null)
        {
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -cam_distance);
        }
	}
}
