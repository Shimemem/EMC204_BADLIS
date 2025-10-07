using UnityEngine;


public class EnemyScript : MonoBehaviour
{

    private Vector3 positionTo, positionStart;
    public float _time;

    private void Start()
    {
        float randomDistance = Random.Range(-10f, 10f);
        positionTo = new Vector3 (randomDistance, 0, randomDistance);
        positionStart = transform.position;
    }

    private void Update()
    {
        _time += Time.deltaTime;
        transform.position = Vector3.Lerp(positionStart, positionStart + positionTo, Mathf.PingPong(_time, 1));
    }

}
