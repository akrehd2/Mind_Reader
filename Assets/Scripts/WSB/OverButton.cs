using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverButton : MonoBehaviour
{
    SpriteRenderer sprite;
    public GameObject[] over = new GameObject[4];

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
            over[0].SetActive(false);
            over[1].SetActive(false);
            over[2].SetActive(false);
            over[3].SetActive(false);
            ScoreMang.remainCard = 5;
            Count.myScore = 0;
            Count.otherScore = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (gameObject.name == "Main")
        {
            over[0].SetActive(false);
            over[1].SetActive(false);
            over[2].SetActive(false);
            over[3].SetActive(false);
            ScoreMang.remainCard = 5;
            Count.myScore = 0;
            Count.otherScore = 0;
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
