using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoginValidator : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;

    public TMP_Text requiredUsernameText;
    public TMP_Text requiredPasswordText;

    public Button LoginButton;

    public void ValidateFields()
    {
        bool usernameOk = !string.IsNullOrWhiteSpace(usernameInput.text);
        bool passwordOk = !string.IsNullOrWhiteSpace (passwordInput.text);

        requiredUsernameText.gameObject.SetActive(!usernameOk);
        requiredPasswordText.gameObject.SetActive(!passwordOk);

        LoginButton.interactable = usernameOk && passwordOk;
    }
}
