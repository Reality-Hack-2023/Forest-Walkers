using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticController : MonoBehaviour
{
    public static XRBaseController leftController, rightController;

    [Range(0,1)]
    public float intensity = 0.25f;
    public float duration = 0.5f;

    [ContextMenu("Trigger Haptic")]
    public void SendHaptics()
    {
        leftController.SendHapticImpulse(intensity, duration);
        rightController.SendHapticImpulse(intensity, duration);

    }

    public static void SendHaptics(float amplitude, float duration)
    {
        leftController.SendHapticImpulse(amplitude, duration);
        rightController.SendHapticImpulse(amplitude, duration);
    }

    public static void SendHaptics(bool isleftController, float amplitude, float duration)
    {
        if(isleftController)
        {
            leftController.SendHapticImpulse(amplitude, duration);
        }
        else
        {
            rightController.SendHapticImpulse(amplitude, duration);
        }
    }

    public static void SendHaptics(XRBaseController controller, float amplitude, float duration)
    {
           controller.SendHapticImpulse(amplitude, duration);
    }
}
