using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        Attacker attacker = GetComponent<Attacker>();

        if(attacker)
        {
            GetComponent<Animator>().SetBool("IsAttacking", true);
        }
    }

}
