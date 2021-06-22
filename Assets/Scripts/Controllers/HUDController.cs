using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public InventoryManager IM;

    public GameObject PauseMenu;

    public Text InventoryList;

    public PlayerController pc;

    private string currentList = "";

    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (DictionaryEntry de in IM.GetItems())
        {
            currentList = ((Item)de.Value).name + " " + ((Item)de.Value).Amount + "\n";
        }

        InventoryList.text = currentList;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(!PauseMenu.activeSelf);
            pc.FreezeMovement();
        }
    }
}
