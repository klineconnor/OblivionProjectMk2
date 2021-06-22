using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTransfer : MonoBehaviour
{
    public void transfer(int sceneId)
    {
        LoadingData.setSceneToLoad(sceneId);
        SceneManager.LoadScene(1);
    }
}
