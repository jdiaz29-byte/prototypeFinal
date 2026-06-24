using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager Instance;
    public GameObject selectedTower;
    void Awake()
    {
        Instance = this;
    }
}
