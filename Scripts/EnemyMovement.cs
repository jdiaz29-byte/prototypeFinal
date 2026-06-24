using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 3f;

    private int waypointIndex = 0;


    void Start()
    {
        GameObject[] waypointObjects = GameObject.FindGameObjectsWithTag("Waypoint");

        System.Array.Sort(
            waypointObjects,
            (a,b) => a.name.CompareTo(b.name)
        );
        
        waypoints = new Transform[waypointObjects.Length];

        for (int i = 0; i < waypointObjects.Length; i++)
        {
            waypoints[i] = waypointObjects[i].transform;

            Debug.Log("Waypoint " + i + ": " + waypointObjects[i].name);
        }
    }

    void Update()
    {
        if(waypointIndex >= waypoints.Length)
        {
            GameManager.Instance.lives--;
            
            Destroy(gameObject);

            return;
        }
        Transform target = waypoints[waypointIndex];

        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );

        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            waypointIndex++;
        }
    }
}
