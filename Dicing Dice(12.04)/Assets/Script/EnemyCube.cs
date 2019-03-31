using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCube : MonoBehaviour {

    public GameObject cube;
    float cubeHp;
    public float enemySpeed = -10.0f;

    // Use this for initialization
    void Start () {
        cubeHp = 100f;
	}

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            Debug.Log(cubeHp);
           // cubeHp = cubeHp - BulletCtrl.damage;
            Destroy(col.gameObject);
            if(cubeHp == 0)
            {
                Destroy(cube);
            }
        }
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(0, 0, enemySpeed * Time.deltaTime);
        if (transform.position.z < -1)
        {
            PlayerCtrl.playerHP--;
            Destroy(gameObject);
        }
    }


}
