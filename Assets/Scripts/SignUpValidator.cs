using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SignUpValidator : MonoBehaviour
{
    public TMP_InputField emailInput;
    public TMP_InputField passwordInput;
    public TMP_InputField usernameInput;

    public TMP_Text requiredEmailText;
    public TMP_Text requiredUsernameText;
    public TMP_Text requiredPasswordText;

    public Button SignUpButton;

    public void ValidateFields()
    {
        bool emailOk = !string.IsNullOrWhiteSpace(emailInput.text);
        bool usernameOk = !string.IsNullOrWhiteSpace(usernameInput.text);
        bool passwordOk = !string.IsNullOrWhiteSpace(passwordInput.text);

        requiredEmailText.gameObject.SetActive(!emailOk);
        requiredUsernameText.gameObject.SetActive(!usernameOk);
        requiredPasswordText.gameObject.SetActive(!passwordOk);

        SignUpButton.interactable = emailOk && usernameOk && passwordOk;
    }
}
