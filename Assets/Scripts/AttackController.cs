using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float projectileSpeed = 50f;
    // ReSharper disable Unity.PerformanceAnalysis
    public void Fire(GameObject cannonPrefab, Transform cannonSpawnPoint)
    {
        GameObject projectile =  Instantiate(cannonPrefab, cannonSpawnPoint.position, cannonSpawnPoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = cannonSpawnPoint.forward * projectileSpeed;
    }
}