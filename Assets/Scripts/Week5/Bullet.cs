using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    private Transform target;

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir =  target.position - transform.position;
        transform.Translate(dir.normalized * bulletSpeed * Time.deltaTime, Space.World);

        if (dir.magnitude < 0.5f)
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
        }
    }
}
