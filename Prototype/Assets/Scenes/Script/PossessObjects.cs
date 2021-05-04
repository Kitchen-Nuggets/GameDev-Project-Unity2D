using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossessObjects : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Possess)
    {
        if (Possess.gameObject.name.Equals("Player"))
        {
            PlayerMovements.NearTheObject = true;
        }
    }

    private void OnTriggerExit2D(Collider2D Possess)
    {
        if (Possess.gameObject.name.Equals("Player"))
        {
            PlayerMovements.NearTheObject = false;
        }
    }
}
