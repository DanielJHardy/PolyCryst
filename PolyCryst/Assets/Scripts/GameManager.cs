using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public float gravity_power = 20;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private IEnumerator playerRespawn(float respawnDelay)
    {
        yield return new WaitForSeconds(respawnDelay);

        Application.LoadLevel(Application.loadedLevel);
    }

    public void playerDeath()
    {
        StartCoroutine(playerRespawn(1.5f));
    }
}
