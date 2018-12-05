using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillExplosion : MonoBehaviour
{
    void Update()
    {
        if (Time.deltaTime >= 0.12)
            Destroy(gameObject);
    }
}
