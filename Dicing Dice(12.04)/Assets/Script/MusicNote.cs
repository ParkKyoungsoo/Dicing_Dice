using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class MusicNote : MonoBehaviour {     


    Rigidbody no;
    public float Speed;
    public SteamVR_Action_Vibration haptic;
    //public GameObject BlueCube_;
    //public GameObject RedCube_;

    GameManager GameManager;
    // Use this for initialization
    void Awake()
    {
        no = GetComponent<Rigidbody>();
    }

    void Start()
    {
        no.velocity = new Vector3(0, 0, -Speed);
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {      
        
    }
    
    public void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "ComboReset":
                Destroy(this.gameObject);
                GameManager.Resetcom();
                GameManager.MissCount();
                break;
        }
    }
   
}
