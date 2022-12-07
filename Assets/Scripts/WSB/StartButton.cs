using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public GameObject help;

    Image sprite;

    private void Start()
    {
        sprite = GetComponent<Image>();
    }

    private void OnMouseOver()
    {
        sprite.color = new Color(1, 1, 1, 0.5f);
    }

    private void OnMouseDown()
    {
        sprite.color = new Color(1, 1, 1, 0.2f);
    }
    void OnMouseUp()
    {
        sprite.color = new Color(1, 1, 1, 1f);
    }

    void OnMouseExit()
    {
        sprite.color = new Color(1, 1, 1, 1f);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Select");
    }

    public void HotGame()
    {
        Debug.Log("¡ÿ∫Ò ¡ﬂ");
    }

    public void AIGame()
    {
        SceneManager.LoadScene("otherGame");
    }

    public void GotoMain()
    {
        SceneManager.LoadScene("Start");
    }

    public void HelpGame()
    {
        help.SetActive(true);
    }
    public void HelpExit()
    {
        help.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
