using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class VerificationTimer : MonoBehaviour
{
    public TMP_Text ExpiryTime;
    public TMP_Text CodeExpired;
    public TMP_Text timerText;
    private Coroutine countdownCoroutine;
    public Button ButtonSubmit;
    public void StartCountdown()
    {
        if (countdownCoroutine != null)
        {
            StopCoroutine(countdownCoroutine);
           
        }
        countdownCoroutine = StartCoroutine(CountdownRoutine());
    }

        private IEnumerator CountdownRoutine ()
        {
            int totalseconds = 6;
            while(totalseconds >= 0)
            {
                int minutes = totalseconds / 60;
                int seconds = totalseconds % 60;
                timerText.text = $"{minutes:00}:{seconds:00}";
                yield return new WaitForSeconds(1f);
                totalseconds --;
            }
            ExpiryTime.gameObject.SetActive(false);
            CodeExpired.gameObject.SetActive(true);
        ButtonSubmit.interactable = false;

        }
    }

