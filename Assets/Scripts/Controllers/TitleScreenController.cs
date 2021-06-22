using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenController : MonoBehaviour
{
    
    public void newGame() {
        LoadingData.setSceneToLoad(2);
        SceneManager.LoadScene(1);

    }

}
