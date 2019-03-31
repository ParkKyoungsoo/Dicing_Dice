using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour {

    public GameObject bullet;
    public Transform bulletTransform;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(bullet, bulletTransform.position, bulletTransform.rotation);
        }
    }
}
