using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

    public string nextSceneName;

	
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {

            case "Bullet":               
                SceneManager.LoadScene(nextSceneName);
                break;
        }

    }

}
