using UnityEngine;

public class HealthV1 : MonoBehaviour
{
    // This "HealthV1" is better for unadjustable HP character

    public int hp = 100;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
