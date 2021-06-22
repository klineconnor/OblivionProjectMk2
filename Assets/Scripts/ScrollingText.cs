using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollingText : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("ScrollText"))
        {
            Debug.Log("Scrolling");
        } else {
            LoadingData.setSceneToLoad(4);
            SceneManager.LoadScene(1);
        }
    }
}
