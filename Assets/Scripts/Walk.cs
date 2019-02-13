using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {
    public int speed = 5;

    public bool moveforward = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton ("Fire1"))
        {

            moveforward = !moveforward;
        }

        if (moveforward)
        {

    

        transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Cylindertags"))
        {
            Destroy(other.gameObject);
        }
    }
}



