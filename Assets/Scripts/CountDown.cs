using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public TMP_Text countdownText;
    public AudioSource getReady;
    public AudioSource goAudio;
    public GameObject lapTimer;
    public GameObject carControls;
    public AudioSource levelMusic;
    public TMP_Text lapCounter;
    private int currentLap = 1;
    public int lapRequirement = 3;
    
    void Start()
    {
        lapCounter.text = currentLap + "/" + lapRequirement;
        getReady.volume = 0.25f;
        goAudio.volume = 0.25f;
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        lapTimer.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        countdownText.text = "3";
        getReady.Play();
        countdownText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        countdownText.gameObject.SetActive(false);
        countdownText.text = "2";
        getReady.Play();
        countdownText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        countdownText.gameObject.SetActive(false);
        countdownText.text = "1";
        getReady.Play();
        countdownText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        countdownText.gameObject.SetActive(false);
        goAudio.Play();
        levelMusic.Play();
        lapTimer.gameObject.SetActive(true);
        carControls.SetActive(true);

    }
    
}
