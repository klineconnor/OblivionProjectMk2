using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactible : MonoBehaviour
{
    public PlayerController pc;

    public Sprite interactible, notInteractible;

    private bool entered;

    private SpriteRenderer sr;

    private void Start()
    {
        sr = transform.parent.GetComponent<SpriteRenderer>();
        entered = false;
    }

    private void Update()
    {
        if (entered && Input.GetKeyDown(KeyCode.Space))
        {
            Interact();
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        entered = true;
        if (other.gameObject.tag == "Player")
        {
            sr.sprite = interactible;
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        entered = false;
        if (other.gameObject.tag == "Player")
        {
            sr.sprite = notInteractible;
        }
        
    }

    protected virtual void Interact()
    {
        Debug.Log("You've interacted with " + gameObject.name);
    }
}
