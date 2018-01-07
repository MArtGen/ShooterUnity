using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public Transform arm;
    GameObject g;
    public GameObject point;
    public int speedArm = 600;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetMouseButton(0))
        {
            Transform g = (Transform)Instantiate(arm, transform.position, transform.rotation);
            g.GetComponent<Rigidbody>().AddForce(transform.forward * speedArm);
            point.GetComponent<Light>().enabled = true;
            Destroy(g.gameObject, 1f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            point.GetComponent<Light>().enabled = false;
        }
	}
}
