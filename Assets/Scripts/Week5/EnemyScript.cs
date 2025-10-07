using TMPro;
using UnityEngine;


public class EnemyScript : MonoBehaviour
{
    public Vector3 movementDirection = Vector3.forward;
    public float distance, speed;

    private Vector3 _startPos;

    void Start()
    {
        _startPos = transform.position;
    }

    void Update()
    {
        float pingPong = Mathf.PingPong(Time.time * speed, distance);
        transform.position = _startPos + movementDirection.normalized * pingPong;
    }
}
