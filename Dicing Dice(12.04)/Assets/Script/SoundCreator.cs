using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(AudioSource))]
public class SoundCreator : MonoBehaviour
{
    float soundTime;
    public Text MusicTime;
   
    public AudioClip bgmSound;  
    public AudioSource bgmPlayer;

    GameManager GameManager;

    public string MusicName = "THE PAT RAT UNITY";

    public static float[] _samples = new float[512];
    public static float[] _freqBand = new float[8];
    public static float[] _bandBuffer = new float[8];
    float[] _bufferDecrease = new float[8];

    // Use this for initialization
    void Start()
    {
        
        bgmPlayer = gameObject.AddComponent<AudioSource>();        
        bgmSound = Resources.Load("Sound/" + MusicName) as AudioClip;
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        bgmPlayer.clip = bgmSound;
        bgmPlayer.Play();
        soundTime = bgmSound.length;
    }

    

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
        MakeFrequencyBands();
        BandBuffer();
        soundTime -= Time.deltaTime;        
        MusicTime.text = " " + soundTime.ToString("N0");
        StartCoroutine(SceneChanger());
    }

    IEnumerator SceneChanger()
    {
        
        GameManager.SaveData();
        if (soundTime <= 0)
        {
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("GameOver");
        }              
    }

    void GetSpectrumAudioSource()
    {
        bgmPlayer.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
    }

    void BandBuffer()
    {
        for (int z = 0; z < 8; ++z)
        {
            if (_freqBand[z] > _bandBuffer[z])
            {
                _bandBuffer[z] = _freqBand[z];
                _bufferDecrease[z] = 0.005f;
            }

            if (_freqBand[z] < _bandBuffer[z])
            {
                _bandBuffer[z] -= _bufferDecrease[z];
                _bufferDecrease[z] *= 1.2f;
            }
        }
    }

    void MakeFrequencyBands()
    {
        int count = 0;

        for (int i = 0; i < 8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;

            if (i == 7)
            {
                sampleCount += 2;
            }
            for (int j = 0; j < sampleCount; j++)
            {
                average += _samples[count] * (count + 1);
                count++;
            }
            average /= count;
            _freqBand[i] = average * 10;
        }
    }

}
