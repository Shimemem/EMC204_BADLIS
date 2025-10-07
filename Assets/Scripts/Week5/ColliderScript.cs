using UnityEngine;
using System.Collections;

public class ColliderScript : MonoBehaviour
{
    public float radius, fireRate, fireDelay;
    public GameObject bulletPrefab;

    void Update()
    {   
        EnemyDetection(transform.position, 10f);
    }

    void EnemyDetection(Vector3 center, float radius)
    {
        fireDelay -= Time.deltaTime;
        if (fireDelay <= 0f)
        {
            Collider[] hits = Physics.OverlapSphere(transform.position, radius);
            foreach (var hit in hits)
            {
                if (hit.CompareTag("Enemy"))
                {
                    Shoot(hit.transform);
                    fireDelay = 1f / fireRate;
                    break;
                }
            }
        }
    }

    void Shoot(Transform target)
    {
        GameObject bulletProj = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bulletProj.GetComponent<Bullet>().SetTarget(target);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
