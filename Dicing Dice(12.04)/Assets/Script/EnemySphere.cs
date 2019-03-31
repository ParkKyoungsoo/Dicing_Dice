using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySphere : MonoBehaviour {

    public GameObject sphere;
    float sphereHp;
    public float enemySpeed = -10.0f;

    // Use this for initialization
    void Start()
    {
        sphereHp = 200.0f;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Debug.Log(sphereHp);
            //sphereHp = sphereHp - BulletCtrl.damage;
            Destroy(col.gameObject);
            if (sphereHp == 0)
            {
                Destroy(sphere);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, enemySpeed * Time.deltaTime);
        if (transform.position.z < -1)
        {
            PlayerCtrl.playerHP--;
            Destroy(gameObject);
        }
    }
}
