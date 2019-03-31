using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Sw : MonoBehaviour {

    GameManager GameManager; 
    public GameObject left_Sword;
    public GameObject right_Sword;  
    int i;
    int j;
    public Transform origin;
    public SteamVR_Action_Pose poseAction;
    public SteamVR_Action_Vibration haptic;
    AudioSource Saber;

    // Use this for initialization
    void Start () {       
        i = 0;
        j = 0;
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Saber = GetComponent<AudioSource>();       
    }

    private void Update()
    {

        //transform.position = origin.transform.TransformPoint(poseAction.GetLocalPosition(SteamVR_Input_Sources.RightHand));
        //Debug.Log(transform.position);
      
        
        


        if (SteamVR_Input.__actions_default_in_GrabPinch.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {            
            i++;
            Debug.Log(i);
            if (i % 2 == 0)
                left_Sword.gameObject.SetActive(false);
            
            if (i % 2 == 1)
            { 
                left_Sword.gameObject.SetActive(true);
                Saber.Play();
            }
            

        }
        if (SteamVR_Input.__actions_default_in_GrabPinch.GetStateDown(SteamVR_Input_Sources.RightHand))
        {
            
            j++;

            if (i % 2 == 0)
                right_Sword.gameObject.SetActive(false);
           
            if (j % 2 == 1)
            {
                right_Sword.gameObject.SetActive(true);
                Saber.Play();
            }

        }
    }
    /*
    public void OnTriggerEnter(Collider other)
    {
      
        switch (other.tag)
        {

            case "NoteGreat":
                Destroy(other.gameObject);
                haptic.Execute(0.1f, 0.2f, 55, 1, SteamVR_Input_Sources.RightHand);
                GameManager.ScoreAdd();
                GameManager.combo();               
                //Instantiate(RedCube_, other.transform.position, Quaternion.identity);
                break;

            case "NoteGreat_1":
                Destroy(other.gameObject);
                haptic.Execute(0.1f, 0.2f, 55, 1, SteamVR_Input_Sources.LeftHand);
                GameManager.ScoreAdd();
                GameManager.combo();               
                //Instantiate(BlueCube_, other.transform.position, Quaternion.identity);
                break;

            case "NoteMiss":
                Destroy(other.gameObject);
                GameManager.Resetcom();
                GameManager.MissCount();
                Instantiate(Miss, other.transform.position, Quaternion.identity);
                break;

            case "NoteMiss_1":
                Destroy(other.gameObject);
                GameManager.Resetcom();
                GameManager.MissCount();
                Instantiate(Miss, other.transform.position, Quaternion.identity);
                break;



        }

    }*/
    
}
