using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private bool uiVisible = false;
    private bool notPlaying = true;
    [SerializeField] GameObject uiObject;
    [SerializeField] GameObject day;


    void Start()
    {
        uiVisible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && notPlaying)
        {
            ToggleUI();
        }
    }

    public void ToggleUI()
    {
        if(uiVisible)
        {
            uiObject.SetActive(false);
        }
        else
        {
            uiObject.SetActive(true);
        }
        
        uiVisible = !uiVisible;
    }

    //Change Weather
    public void ToRain()
    {
        Debug.Log("Changed Weather to Rain.");
    }

    public void ToSnow()
    {
        Debug.Log("Changed Weather to Snow.");
    }

    public void ToClear()
    {
        Debug.Log("Changed Weather to Clear.");
    }

    //Change Daytime
    public void ToDay()
    {
        Debug.Log("Changed Daytime to Day.");
        day.SetActive(true);
    }

    public void ToNight()
    {
        Debug.Log("Changed Daytime to Night.");
    }

    public void ToEvening()
    {
        Debug.Log("Changed Daytime to Evening.");
    }

    //Animations
    public void PlayArachneWalk()
    {

    }

    public void PlayArachneIdle()
    {
        
    }

    public void PlayArachneRun()
    {
        
    }

    public void PlayMonsterWalk()
    {
        
    }

    public void PlayMonsterIdle()
    {
        
    }

    public void PlayMonsterRun()
    {
        
    }

    public void PlayCustom()
    {
        
    }
}
