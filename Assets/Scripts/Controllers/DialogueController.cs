using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    public GameObject HUD;

    public Button advanceDialogue;

    public Text currentText;

    public PlayerController pc;

    Queue<string> dialogue;

    void Start()
    {
        HUD.SetActive(false);
        dialogue = new Queue<string>();
        advanceDialogue.onClick.AddListener(NextDialogue);
    }

    public void NextDialogue()
    {
        if (dialogue.Count <= 0)
        {
            Debug.Log("Stop talking");
            HUD.SetActive(false);
            pc.FreezeMovement();
        } else
        {
            currentText.text = dialogue.Dequeue();
        }
    }

    public void LoadBasicDialogue(List<string> dialogue)
    {
        this.dialogue.Clear();

        foreach (string iter in dialogue)
        {
            this.dialogue.Enqueue(iter);
        }

        Debug.Log("Load dialogue" + this.dialogue.Count);
        HUD.SetActive(true);
        NextDialogue();
    }
}
