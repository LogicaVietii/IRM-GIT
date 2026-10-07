using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public Image scoreBackground; 

    private int score = 0;
    private Color originalColor;

    void Start()
    {
        scoreText.text = "Score: 0";
        originalColor = scoreBackground.color;
    }

    public void AddPoints(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;

        StartCoroutine(HitEffect());
    }

    IEnumerator HitEffect()
    {
        scoreBackground.color = Color.green;

        yield return new WaitForSeconds(5f);

        scoreBackground.color = originalColor;
    }
}