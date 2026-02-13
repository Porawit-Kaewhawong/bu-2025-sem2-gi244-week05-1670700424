using UnityEngine;

public class GameState : MonoBehaviour
{
    public int hitCount = 0;

    void OnTriggerEnter(Collider other)
    {
        /* (Not a good way) add "hitCount" by finding game object's starting name "Dog"
         * because multiple different objects could have the same name.
        if (other.gameObject.name.StartsWith("Dog"))
        {
            hitCount++;
        }
        */

        /* (Better but not the best way) add "hitCount" by finding game object with tag "Enemy"
         * because writing tag name wrong will automatically return false
        if (other.gameObject.tag == "Enemy")
        {
            hitCount++;
        }
        */

        // (The best way) to add "hitCount" by finding game object with tag "Enemy" the same as above
        // but by using "CompareTag" instead of "gameObject.tag" will debug error, which is easier to notice an error
        if (other.gameObject.CompareTag("Enemy"))
        {
            hitCount++;
        }

        if (hitCount >= 10)
        {
            Debug.Log("Game Over!");
            Time.timeScale = 0;
        }
    }
}
