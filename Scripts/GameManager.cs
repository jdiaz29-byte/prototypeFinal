using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int kills = 0;
    public int lives = 10;
    public int wave = 1;

    public int gold = 100;

    public int killsToWin = 25;

    void Awake()
    {
        Instance = this;
    }

    public void EnemyKilled()
    {
        kills++;
        gold += 10;
    }
}
