using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIManager : MonoBehaviour
{
    public GameObject leaderboardpanel;
    public GameObject mainmenupanel;
    public GameObject loginpanel;
    public GameObject signuppanel;
    public GameObject verificationpanel;
    public VerificationTimer timerScript;
    public Button ButtonSubmit;
    public Button ButtonLogin;

   /* public void Start()
    {
        ButtonLogin.interactable = false;
        string panel = PlayerPrefs.GetString("OpenPanel", "");
        loginpanel.SetActive(false);
        signuppanel.SetActive(false);
        mainmenupanel.SetActive(false);

        if (panel == "Panel_MainMenu")
        {
            mainmenupanel.SetActive(true);
        }
        else
        {
            loginpanel.SetActive(true);
        }
        PlayerPrefs.DeleteKey("OpenPanel");
    }*/

    //Main Menu Panel
    public void LogOutButton()
    {
        /*mainmenupanel.SetActive(false);
        loginpanel.SetActive(true);*/
        Application.Quit();
    }
         

    public void PlayButton ()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenLeaderBoardPanel()
    {
        leaderboardpanel.SetActive(true);
    }

    public void CloseLeaderBoardPanel()
    {
        leaderboardpanel.SetActive(false);
    }

    //Login Panel
     public void LoginButton()
    {
        mainmenupanel.SetActive(true);
        loginpanel.SetActive(false);
    }
    public void ClickToSignupButton()
    {
        signuppanel.SetActive(true);
        loginpanel.SetActive(false);
    }

    //Sign Up Panel

    public void SignUpButton()
    {
       verificationpanel.SetActive(true);
        timerScript.StartCountdown();
        ButtonSubmit.interactable = true;
            }
    public void ResendButton()
    {
        ButtonSubmit.interactable = true;
        timerScript.StartCountdown();
        timerScript.CodeExpired.gameObject.SetActive(false);
        timerScript.ExpiryTime.gameObject.SetActive(true);
    }

    public void TextLoginButton()
    {
        loginpanel.SetActive(true);
        signuppanel.SetActive(false);
    }

    public void SubmitButton()
    {
        mainmenupanel.SetActive(true);
        signuppanel.SetActive(false);
    }

    //Verification Panel
    public void CloseVerificationPanel()
    {
        verificationpanel.SetActive(false);
    }

    

}
