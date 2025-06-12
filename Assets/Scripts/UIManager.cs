using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject PanelGameOverMenu;
    public TMP_Text ScoreText;
    public TMP_Text ScoreinGameText;

    private IEnumerator ShowGameOverMenuDelayedIEN()
    {
        yield return new WaitForSeconds(2.5f);
        ScoreinGameText.gameObject.SetActive(false);
        PanelGameOverMenu.SetActive(true);
        Time.timeScale = 0f;
        ScoreText.text = Score.score.ToString();
    }

    public void ShowGameOverMenuDelayed()
    {
        StartCoroutine(ShowGameOverMenuDelayedIEN());
    }
 public void PlayAgainButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }
    public void MainMenuButton()
    {
        //PlayerPrefs.SetString("OpenPanel", "Panel_MainMenu");
        SceneManager.LoadScene("MainMenu");
    }
  
}
