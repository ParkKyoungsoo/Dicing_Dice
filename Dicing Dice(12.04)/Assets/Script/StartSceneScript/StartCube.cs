using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCube : MonoBehaviour
{

    public int _band;
    public float _starScale, _scaleMultiplier;
    public bool _useBuffer;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (InfoCube._bandBuffer[_band] * _scaleMultiplier) + _starScale, transform.localScale.z);
        }
        if (!_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (InfoCube._freqBand[_band] * _scaleMultiplier) + _starScale, transform.localScale.z);
        }

    }
}
