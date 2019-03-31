using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour {

    public GameObject Music123;
    public GameObject MusicUnity;
    public Collider M1Col;
    public Collider M2col;

    public static ColliderManager instance;




    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }



    // Use this for initialization
    void Start () {
		
        


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
