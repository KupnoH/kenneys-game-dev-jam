using UnityEngine;

public class CameraController : MonoBehaviour
{

    public static Animator stateDrivenCameraAnimator;
    public static string Izometric = "Izometric";
    public static string CloseShip = "CloseShip";
    public static string ThirdPerson = "ThirdPerson";


    public static void SetCamera(string AnimationStateParameter)
    {
        stateDrivenCameraAnimator.SetTrigger(AnimationStateParameter);
    }
}
