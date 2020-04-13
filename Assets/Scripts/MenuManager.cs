using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public Animator simplenav;
    public Animator inventoryholder;
    public bool MenuOpen;

    public PlayerController pc;
    public int Umbrella;
    public GameObject inventoryUmbrella;
    public bool wearUmbrella;
    public bool ownUmbrella;
    public GameObject UsedUmbrella;

    public int goldCount;
    public Text goldText;

    public Button ShopUmbrella;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        goldText.text = "Gold:" + goldCount;
        Umbrella = PlayerPrefs.GetInt("Umbrella");

        if (Umbrella == 1)
        {
            inventoryUmbrella.SetActive(true);
        }

        

        if (goldCount >= 1 && ownUmbrella == false)
        {
            ShopUmbrella.interactable = true;
        }


    }

    public void OpenNav()
    {
        if (MenuOpen == false)
        {
            simplenav.SetBool("Open", true);
            Time.timeScale = 0;
            MenuOpen = true;
        }

        else if (MenuOpen == true)
        {
            simplenav.SetBool("Open", false);
            Time.timeScale = 1;
            MenuOpen = false;
        }
    }

    public void CLoseNav()
    {
        simplenav.SetBool("Open", false);
        Time.timeScale = 1;
        MenuOpen = false;
    }

    public void OpenInv()
    {
        inventoryholder.SetBool("Open", true);
    }

    public void CloseInv()
    {
        inventoryholder.SetBool("Open", false);
    }


    public void UseUmbrella()
    {
        wearUmbrella = true;
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("Umbrella", 0);
        inventoryUmbrella.SetActive(false);
        wearUmbrella = false;
    }
}
