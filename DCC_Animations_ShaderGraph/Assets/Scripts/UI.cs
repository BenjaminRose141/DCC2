using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    [SerializeField] Animator animArachne;
    [SerializeField] Animator animMonster;
    [SerializeField] GameObject controls;
    [SerializeField] GameObject spells;
    bool controlsVisible;
    [SerializeField] float timerStart;
    float timerCurrent;
    bool timing = false;
    [SerializeField] GameObject spell1;
    [SerializeField] GameObject spell2;
    GameObject clone1 = null;
    GameObject clone2 = null;



    void Start()
    {
        uiVisible = false;
        timerCurrent = timerStart;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleUI();
        }

        if(timing)
        {   
            spells.SetActive(true);
            //Debug.Log("Timer: " + timerCurrent);
            timerCurrent = timerCurrent - Time.deltaTime;
            //Debug.Log("Timer: " + timerCurrent);

            if(timerCurrent <= 0)
            {
                animMonster.Play("Custom");
            }
            
            if (timerCurrent <= -1)
            {
                timing = false;
                timerCurrent = timerStart;
                Destroy(clone1);
                Destroy(clone2);
            }
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

    public void Controls()
    {
        controls.SetActive(controlsVisible);
        controlsVisible = !controlsVisible;
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
        night.SetActive(false);
        evening.SetActive(false);
    }

    public void ToNight()
    {
        Debug.Log("Changed Daytime to Night.");
        day.SetActive(false);
        night.SetActive(night);
        evening.SetActive(false);
    }

    public void ToEvening()
    {
        Debug.Log("Changed Daytime to Evening.");
        day.SetActive(false);
        night.SetActive(false);
        evening.SetActive(true);
    }

    //Animations
    public void PlayArachneWalk()
    {
        animArachne.Play("Walk");
    }

    public void PlayArachneIdle()
    {
        animArachne.Play("Idle");
    }

    public void PlayArachneRun()
    {
        animArachne.Play("Run");
    }

    public void PlayArachneAttack()
    {
        animArachne.Play("Attack");
    }

    public void PlayMonsterWalk()
    {
        animMonster.Play("Walk");
    }

    public void PlayMonsterIdle()
    {
        animMonster.Play("Idle");
    }

    public void PlayMonsterRun()
    {
        animMonster.Play("Run");
    }

    public void PlayCustom()
    {
        animArachne.Play("Channel");
        clone1 = Instantiate(spell1);
        clone2 = Instantiate(spell2);
        animMonster.Play("Idle");
        timing = true;

    }
}
