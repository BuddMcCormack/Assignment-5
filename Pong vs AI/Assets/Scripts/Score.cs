using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Paddle paddle;


    public TMPro.TMP_Text playerScoreText;
    public TMPro.TMP_Text AIScoreText;

    private int playerScore;
    private int AIScore;

    public void PlayerScores()
    {
        playerScore++;
        this.playerScoreText.text = playerScore.ToString();
        this.paddle.ResetPosition();
    }
    public void AIScores()
    {
        AIScore++;
        this.AIScoreText.text = AIScore.ToString();
        this.paddle.ResetPosition();
    }
}
