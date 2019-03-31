using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour {


    public GameObject Blue;
    public GameObject Red;
    //public GameObject Blue3;
    //public GameObject Red1;
    //public GameObject Red2;
    //public GameObject Red3;

    // bool noteColor;

    GameObject notePosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Vector3 [] position = new Vector3[4];
        //position[0] = new Vector3(-1f, 8.5f, -14f);
        //position[1] = new Vector3(-1f, 7.5f, -14f);
        //position[2] = new Vector3(1f, 8.5f, -14f);
        //position[3] = new Vector3(1f, 7.5f, -14f);

        //GameObject[] note = new GameObject[2];
        //note[0] = blueNote;
        //note[1] = redNote;

        //if (Input.GetKeyDown(key))
        //{
        //    Instantiate(note[Random.Range(0,2)], position[Random.Range(0,4)], Quaternion.identity);
        //}
        Vector3[] position = new Vector3[4];
        position[0] = new Vector3(-0.7f, 8.5f, -14f);
        position[1] = new Vector3(-0.7f, 7.0f, -14f);
        position[2] = new Vector3(0.7f, 8.5f, -14f);
        position[3] = new Vector3(0.7f, 7.0f, -14f);

        GameObject[] note = new GameObject[2];

        note[0] = Blue;
        note[1] = Red;
        //note[2] = Blue3;
        //note[3] = Red1;
        //note[4] = Red2;
        //note[5] = Red3;

        notePosition = note[Random.Range(0, 2)];
        //if (notePosition == note[0] || notePosition == note[1] || notePosition == note[2]) noteColor = true;
        //if (notePosition == note[3] || notePosition == note[4] || notePosition == note[5]) noteColor = false;


       

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (notePosition == Blue)
            {
                Instantiate(Blue, position[Random.Range(0, 2)], Quaternion.identity);
            }
            if (notePosition == Red)
            {
                Instantiate(Red, position[Random.Range(2, 4)], Quaternion.identity);
            }
        }

    }    
}
