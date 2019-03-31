using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour {

    public static int playerHP = 10;
    public string nextSceneName;
    public GameObject player;

    public Camera camera;
    private Ray ray;
    private RaycastHit hit;
    private GameObject hitObject;


    public GameObject bullet;
    public Transform bulletLeftTransform;
    public Transform bulletRightTransform;

    GameManager Score;
    

    // Use this for initialization
    void Start () {
       // Score = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, bulletLeftTransform.position, bulletLeftTransform.rotation);
            Debug.Log("LeftClick");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(bullet, bulletRightTransform.position, bulletRightTransform.rotation);
            Debug.Log("RightClick");
        }


        if (playerHP == 0)
        {
            Debug.Log(playerHP);
            SceneManager.LoadScene(nextSceneName);
        }
      

    }

}
     
