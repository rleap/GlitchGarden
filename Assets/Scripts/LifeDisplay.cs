using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    [SerializeField] int lives = 10;
    [SerializeField] int damage = 1;
    Text lifeText;

    void Start()
    {
        lifeText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        lifeText.text = lives.ToString();
    }

    public int LivesRemaining()
    {
        return lives;
    }

    public void AddLife(int amount)
    {
        lives += amount;
        UpdateDisplay();
    }

    public void LoseLife()
    {

        lives -= damage;
        UpdateDisplay();

        if (lives <= 0)
        {
            FindObjectOfType<LevelLoader>().LoadLoseScene();
        }

    }
}
