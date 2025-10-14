using UnityEngine;

public class CameraZoomScript : MonoBehaviour
{
    public Camera mainCam;
    bool buttonReleased;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            buttonReleased = false;
            if (mainCam.fieldOfView >= 20f)
            {
                mainCam.fieldOfView -= 1f;
            }
        }

        if (Input.GetMouseButtonUp(1))
        {
            buttonReleased = true;
        }

        if (buttonReleased)
        {
            if (mainCam.fieldOfView <= 60f)
            {
                mainCam.fieldOfView += 1f;
            }
        }
    }
}
