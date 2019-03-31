using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScene : MonoBehaviour {

    public GameObject cube;
    public AudioSource audio;

    // Use this for initialization

    private void OnTriggerEnter(Collider other)
    {
        switch(other.tag)
        {
            case "Bullet":
                audio.Pause();
                cube.gameObject.SetActive(false);
                break;
        }

    }


}
