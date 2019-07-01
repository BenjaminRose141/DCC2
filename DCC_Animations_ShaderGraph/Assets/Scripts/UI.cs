using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private bool uiVisible = false;
    [SerializeField] GameObject uiObject = null;
    [SerializeField] GameObject day = null;
    [SerializeField] GameObject night = null;
    [SerializeField] GameObject evening = null;
    [SerializeField] GameObject rain = null;
    [SerializeField] GameObject snow = null;
    [SerializeField] GameObject clear = null;



    void Start()
    {
        uiVisible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
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
        rain.SetActive(true);
        clear.SetActive(false);
        snow.SetActive(false);
    }

    public void ToSnow()
    {
        Debug.Log("Changed Weather to Snow.");
        rain.SetActive(false);
        clear.SetActive(false);
        snow.SetActive(true);
    }

    public void ToClear()
    {
        Debug.Log("Changed Weather to Clear.");
        rain.SetActive(false);
        clear.SetActive(true);
        snow.SetActive(false);
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
