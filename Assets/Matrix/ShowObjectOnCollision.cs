using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowObjectOnCollision : MonoBehaviour
{
    [SerializeField]
    string tagName;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == tagName)
            GameObject.Find("BlackSpikeCollective").transform.localScale = new Vector3(1, 1, 1);
    }
}
