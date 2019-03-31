using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAudio : MonoBehaviour {

    public int Band;
    public float Min, Max;
    Light light;

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        light.intensity = (AudioPeer._bandBuffer[Band] * (Max - Min)) + Min;
	}
}

