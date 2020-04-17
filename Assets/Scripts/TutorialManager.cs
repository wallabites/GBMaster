using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    public int popupIndex;
    public float waitTime = 2f;
    public PlayerController player;
    public LeftJoystick LJ;

    // Start is called before the first frame update
    private void Start()
    {
        //player.jumpForce = 0;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popupIndex)
            {
                popUps[i].SetActive(true);
            }
            else
            {
                popUps[i].SetActive(false);
            }
            {

            }
            if (popupIndex == 0)
            {
                if (LJ.inputVector.x !=0)
                {
                    //Debug.Log("joystickmoved");
                    popupIndex++;
                }
            }
            else if (popupIndex == 1)
            {
                if (CnInputManager.GetButtonDown("Jump"))
                {
                    //player.jumpForce = 8;
                    popupIndex++;
                }
            }
            else if (popupIndex == 2)
            {
                waitTime -= Time.deltaTime;
                if (waitTime <= 0)
                {
                    popupIndex ++;
                }
            }
           
        }
    }
}