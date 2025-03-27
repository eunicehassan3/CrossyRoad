using TMPro;
using UnityEngine;

public class ScoreBehavior : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = PlayerBehavior.score;
    }

    // Update is called once per frame
    void Update()
    {
        score = PlayerBehavior.score;
        scoreText.text = "Score: " + score;
    }
}
