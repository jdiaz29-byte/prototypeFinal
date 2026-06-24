using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI waveText;
    public TextMeshProUGUI killsText;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI goldText;
    public GameObject gameOverText;
    public GameObject victoryText;

    void Update()
    {
        waveText.text = 
        "Wave: " + GameManager.Instance.wave;
        
        killsText.text = 
        "Kills: " + GameManager.Instance.kills;

        livesText.text = 
        "Lives: " + GameManager.Instance.lives;

        goldText.text = 
        "Gold: " + GameManager.Instance.gold;


        if (GameManager.Instance.lives <= 0)
        {
            gameOverText.SetActive(true);

            Time.timeScale = 0;
        }
        if (GameManager.Instance.kills >= GameManager.Instance.killsToWin)
        {
            victoryText.SetActive(true);

            Time.timeScale = 0;
        }
    }
}
