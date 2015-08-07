using UnityEngine;
using System.Collections;

public class gravModZone : MonoBehaviour {

    public float modifiedPower = 10;
    public float normal_gravPower = 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().gravity_power = modifiedPower;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().gravity_power = normal_gravPower;
        }
    }
}
