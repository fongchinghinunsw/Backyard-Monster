using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D otherColider)
    {
        Attacker attacker = otherColider.GetComponent<Attacker>();
        if (attacker)
        {

        }
    }
}
