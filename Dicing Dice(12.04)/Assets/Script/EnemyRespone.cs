using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespone : MonoBehaviour {

    public GameObject enemyCube;
    public GameObject enemySphere;
    int enemyCubeCount = 5;
    int enemySphereCount = 5;


    public float interval = 1.5f;
    float term;

	// Use this for initialization
	void Start () {
        term = interval;
	}
	
	// Update is called once per frame
	void Update () {

        term += Time.deltaTime;
        if (enemyCubeCount > 0)
        {
            if (term >= interval)
            {
                Vector3 pos = transform.position;
                Instantiate(enemyCube, pos, transform.rotation);
                term -= interval;
                enemyCubeCount--;
                Debug.Log(enemyCubeCount);
            }
        }
        if (enemyCubeCount == 0)
        {
            if (enemySphereCount > 0)
            {
                if (term >= interval)
                {
                    Vector3 pos = transform.position;
                    Instantiate(enemySphere, pos, transform.rotation);
                    term -= interval;
                    enemySphereCount--;
                }
            }

        }
    }
}
