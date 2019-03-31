using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class CubeSaber : MonoBehaviour {


    GameManager GameManager;
   

    public SteamVR_Action_Vibration haptic;
    public GameObject Miss;
    public GameObject RedCube_;
    public GameObject BlueCube_;




    //AudioSource test;
    
    

    // Use this for initialization
    void Start () {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //test = GetComponent<AudioSource>();
    }

    // Update is called once per frame


    public void OnTriggerEnter(Collider other)
    {

        switch (other.tag)
        {

            case "NoteGreat":
                Destroy(other.gameObject);               
                haptic.Execute(0.1f, 0.2f, 55, 1, SteamVR_Input_Sources.LeftHand);
                GameManager.ScoreAdd();
                GameManager.combo();
               // test.Play();
                Instantiate(BlueCube_, other.transform.position, Quaternion.identity);
                break;

            case "NoteGreat_1":
                Destroy(other.gameObject);              
                haptic.Execute(0.1f, 0.2f, 55, 1, SteamVR_Input_Sources.RightHand);
                GameManager.ScoreAdd();
                GameManager.combo();
                // test.Play();
                Instantiate(RedCube_, other.transform.position, Quaternion.identity);
                break;
            /*
            case "NoteMiss":
                Destroy(other.gameObject);
                Destroy(other.gameObject.transform.parent.gameObject);
                GameManager.Resetcom();
                GameManager.MissCount();
                Instantiate(Miss, other.transform.position, Quaternion.identity);
                haptic.Execute(0.1f, 0.2f, 55, 1, SteamVR_Input_Sources.LeftHand);
                break;

            case "NoteMiss_1":
                Destroy(other.gameObject);
                Destroy(other.gameObject.transform.parent.gameObject);
                GameManager.Resetcom();
                GameManager.MissCount();
                Instantiate(Miss, other.transform.position, Quaternion.identity);
                haptic.Execute(0.1f, 0.2f, 55, 1, SteamVR_Input_Sources.RightHand);
                break;

            case "Nor":
                Destroy(other.gameObject);
                GameManager.ScoreAdd();
                GameManager.combo();
                haptic.Execute(0.1f, 0.2f, 55, 1, SteamVR_Input_Sources.RightHand);
                Instantiate(RedCube_, other.transform.position, Quaternion.identity);
                break;
            case "Nor_1":
                Destroy(other.gameObject);
                GameManager.ScoreAdd();
                GameManager.combo();
                haptic.Execute(0.1f, 0.2f, 55, 1, SteamVR_Input_Sources.LeftHand);
                Instantiate(RedCube_, other.transform.position, Quaternion.identity);
                break;
                */



        }

    }

}
