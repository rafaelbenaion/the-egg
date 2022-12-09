using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{

    [SerializeField]
    KeyCode restartKey;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(restartKey))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
    }
}
 