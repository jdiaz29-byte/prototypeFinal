using UnityEngine;

public class TowerAttack : MonoBehaviour
{
    public float range = 8f;
    public float fireRate = 2f;
    public int damage = 1;
    public int cost = 50;
    public string dragonType = "Fire";

    private float fireCountdown = 0f;

    void Update()
    {
        fireCountdown -= Time.deltaTime;
        GameObject[ ] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(
                transform.position,
                enemy.transform.position
            );

            if (distance <= range)
            {
                if (fireCountdown <= 0f)
                {
                    Shoot(enemy);
                    fireCountdown = 1f / fireRate;
                }
                break;
            }
        }
    }

    void Shoot(GameObject enemy)
    {
        EnemyHealth health = enemy.GetComponent<EnemyHealth>();

        if (health != null)
        {
            health.TakeDamage(damage);

            Debug.Log (
                dragonType + 
                " Dragon Attacks " +
                enemy.name
            );
        }
    }
}
