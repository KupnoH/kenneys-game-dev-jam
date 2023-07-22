using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public void Disembark(GameObject playerPrefab, Transform playerSpawnPoint, Vector3 spawnPos)
    {
        GameObject player = Instantiate(playerPrefab, playerSpawnPoint.position, playerSpawnPoint.rotation);
        player.transform.position = spawnPos;

        CameraController.SetCamera(CameraController.ThirdPerson);
        CameraManager.instance.izometricVirtualCamera.Follow = player.transform;
        CameraManager.instance.izometricVirtualCamera.LookAt = player.transform;
    }
}