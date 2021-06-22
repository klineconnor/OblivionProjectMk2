using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationTransfer : MonoBehaviour
{
    public int sceneId;

    void OnTriggerEnter2D(Collider2D collider)
    {
        LoadingData.setSceneToLoad(sceneId);
        SceneManager.LoadScene(1);
    }
}
