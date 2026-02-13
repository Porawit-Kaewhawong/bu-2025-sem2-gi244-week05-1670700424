using UnityEngine;

public class Food : MonoBehaviour
{
    public int attackPoint = 5;

    void OnTriggerEnter(Collider other)
    {
        // Debug log
        Debug.Log("Hit " + other.gameObject.name);

        // Create new variable "health" and get other game object's component called "HealthV1"
        var health = other.gameObject.GetComponent<HealthV1>();

        // Run TakeDamage method using "attackPoint" inside "health"
        health.TakeDamage(attackPoint);
    }
}
