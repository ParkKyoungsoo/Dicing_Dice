using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletCtrl : MonoBehaviour {
       

    public float speed = 10000.0f;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        //ScoreADD = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
      

        
    }

    public void OnTriggerEnter(Collider other)
    {
        

    }
}
