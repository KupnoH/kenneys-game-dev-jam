using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;
    private void Awake()
    {
        instance = this;
    }
    public Cinemachine.CinemachineVirtualCamera izometricVirtualCamera;
}
