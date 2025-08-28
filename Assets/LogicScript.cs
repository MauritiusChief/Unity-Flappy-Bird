using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public TMP_Text finalScoreText;
    public GameObject gameOverScreen;
    public bool birdIsAlive = true;
    public AudioSource gameOverSong;

    [ContextMenu("DEBUG Increase Score")]
    public void IncreaseScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString();
    }

    [ContextMenu("DEBUG Reset Scene")]
    public void ResetScene()
    {
        score = 0;
        scoreText.text = score.ToString();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    [ContextMenu("DEBUG Game Over")]
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        finalScoreText.text = "You fly through " + score.ToString() + " pipes.";
        birdIsAlive = false;
        gameOverSong.Play();
    }
}
