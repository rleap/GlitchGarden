using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Attacker>())
        {
            FindObjectOfType<LifeDisplay>().LoseLife();
        }

        Destroy(other.gameObject, 0.5f);
    }
}
