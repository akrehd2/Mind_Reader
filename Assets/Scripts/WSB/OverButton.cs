using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverButton : MonoBehaviour
{
    SpriteRenderer sprite;
    public GameObject over;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void OnMouseOver()
    {
        sprite.color = new Color(1, 1, 1, 0.5f);
    }

    private void OnMouseDown()
    {
        sprite.color = new Color(1, 1, 1, 0.2f);

        if(gameObject.name == "Retry")
        {
            Time.timeScale = 1f;
            over.SetActive(false);
            SceneManager.LoadScene("otherGame");
        }
        else if (gameObject.name == "Main")
        {
            SceneManager.LoadScene("Start");
        }
    }
    void OnMouseUp()
    {
        sprite.color = new Color(1, 1, 1, 1f);
    }

    void OnMouseExit()
    {
        sprite.color = new Color(1, 1, 1, 1f);
    }
}
