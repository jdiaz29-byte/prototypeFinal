using UnityEngine;

public class TowerSelector : MonoBehaviour
{
    public GameObject fireDragon;
    public GameObject iceDragon;
    public GameObject lightningDragon;
    public int fireCost = 50;
    public int iceCost = 75;
    public int lightningCost = 100;

    public void SelectFire()
    {
        if (GameManager.Instance.gold >= fireCost)
        {
        BuildManager.Instance.selectedTower = 
            fireDragon;
        }
    }
    public void SelectIce()
    {
        if (GameManager.Instance.gold >= iceCost)
        {
        BuildManager.Instance.selectedTower = 
            iceDragon;
        }
    }
    public void SelectLightning()
    {
        if (GameManager.Instance.gold >= lightningCost)
        {
        BuildManager.Instance.selectedTower = 
            lightningDragon;
        }
    }
}
