using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour {

    public GameObject MusicBox;
    public GameObject Cube;
    public AudioSource Audio;

    string musicname;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                GameObject hitObj = hit.collider.gameObject;

                if (hitObj.gameObject == MusicBox)
                {
                    Cube.gameObject.SetActive(true);
                    Audio.Play();
                }
            }
        }


    }
}
