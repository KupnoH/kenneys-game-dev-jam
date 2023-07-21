using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public void Fire(GameObject cannonPrefab, Transform cannonSpawnPoint)
    {
        Instantiate(cannonPrefab, cannonSpawnPoint.position, cannonSpawnPoint.rotation);
    }
}