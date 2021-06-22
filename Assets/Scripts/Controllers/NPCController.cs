using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : Interactible
{

    public DialogueController dialogueController;

    public List<string> dialogue;

    protected override void Interact()
    {
        pc.FreezeMovement();
        dialogueController.LoadBasicDialogue(dialogue);
    }
}
