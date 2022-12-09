using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string tagName;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == tagName)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
