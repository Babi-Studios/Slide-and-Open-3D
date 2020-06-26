using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    Rigidbody enemyRigidbody;

    private void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        enemyRigidbody.AddForce(Vector3.back * moveSpeed, ForceMode.Acceleration);
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
