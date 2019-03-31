using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Controller_Ctrl : MonoBehaviour {

    public GameObject bullet;
    public Transform bulletTransform;
    public string nextSceneName;
    


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Input.__actions_default_in_GrabPinch.GetStateDown(SteamVR_Input_Sources.Any))
        {
            Instantiate(bullet, bulletTransform.position, bulletTransform.rotation);
                    
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Start":
                Destroy(this.gameObject);
                SceneManager.LoadScene(nextSceneName);
                break;

            case "Exit":

                break;
        }

    }

}
