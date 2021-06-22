using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Sprite playerFront, playerBack, playerRight, playerLeft;

    private SpriteRenderer sr;

    private Rigidbody2D rb;

    private float horizontal, vertical;

    public float speed = 5.0f;

    private bool freezeMovement;

    EncounterManager EC;
    int encounterNumber;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        freezeMovement = false;
        EC = GameObject.FindGameObjectWithTag("EncounterManager").GetComponent<EncounterManager>();
        encounterNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (!freezeMovement){
            if (horizontal > 0)
            {
                sr.sprite = playerRight;
            }
            else if (vertical > 0)
            {
                sr.sprite = playerFront;
            }
            else if (horizontal < 0)
            {
                sr.sprite = playerLeft;
            }
            else if (vertical < 0)
            {
                sr.sprite = playerBack;
            }

            if (horizontal != 0 || vertical != 0)
            {
                encounterNumber++;
                if (encounterNumber > 1000) {
                    EC.GenerateEncounter();
                    encounterNumber = 0;
                }
            }

        }
        
    }

    private void FixedUpdate()
    {
        if (freezeMovement)
        {

        }else
        {
            rb.velocity = new Vector2(horizontal * speed, vertical * speed);
        }
        
    }

    public void FreezeMovement()
    {
        freezeMovement = !freezeMovement;
    }
}
