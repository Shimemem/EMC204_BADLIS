using UnityEngine;
using System.Collections;

public class ColliderScript : MonoBehaviour
{
    public float radius;


    void EnemyDetection(Vector3 center, float radius)
    {
        Collider[] enemyDetected = Physics.OverlapSphere(center, radius);
        foreach (var enemy in enemyDetected) 
        {
            enemy.SendMessage("Enemy Detected");
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
