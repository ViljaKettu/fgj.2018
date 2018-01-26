using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //TODO: add location
        SceneManager.LoadScene("ADD NAME OF SCENE HERE");
    }
}
