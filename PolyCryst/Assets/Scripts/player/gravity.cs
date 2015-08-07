using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour
{

    //gravity
    public float grav_power = 20;

    //rotation
    public float rot_speed = 80;


    // Use this for initialization
    void Start(){

    }


    // Update is called once per frame
    void Update()
    {



            grav_power = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().gravity_power;

            if (Input.GetAxisRaw("Horizontal") == -1)
            {
                Camera.main.transform.Rotate(0f, 0f, -rot_speed * Time.deltaTime);
            }
            else if (Input.GetAxisRaw("Horizontal") == 1)
            {
                Camera.main.transform.Rotate(0f, 0f, rot_speed * Time.deltaTime);
            }

            Physics.gravity = (-Camera.main.transform.up) * grav_power;

        

    }
}
