using UnityEngine;

public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;

    private TMPro.TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText = GetComponent<TMPro.TextMeshProUGUI>();
        scoreText.text = CurrentScore.ToString();
    }
}
