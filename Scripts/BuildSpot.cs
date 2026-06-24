using UnityEngine;

public class BuildSpot : MonoBehaviour
{
    private bool occupied = false;
    void OnMouseDown()
    {
        if (occupied)
            return;

        if (BuildManager.Instance.selectedTower == null)
            return;

        GameObject tower =
            BuildManager.Instance.selectedTower;
        
        int cost =
            tower.GetComponent<TowerAttack>().cost;

        if (GameManager.Instance.gold >= cost)
        {
            GameManager.Instance.gold -= cost;
        
            Instantiate(
                tower,
                transform.position + new Vector3(0, 0.5f, 0),
                Quaternion.identity
            );
        occupied = true;
        }
        else
        {
            Debug.Log("Not Enough Gold!");
        }
    }
}
