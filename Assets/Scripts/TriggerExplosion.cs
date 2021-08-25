using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExplosion : MonoBehaviour
{
    public GameObject explosion;

    private void OnCollisionEnter()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
