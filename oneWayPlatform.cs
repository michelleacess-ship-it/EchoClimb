using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;
    private float resetTime;

    void Awake()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            effector.rotationalOffset = 180f;
            resetTime = 0.2f;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            effector.rotationalOffset = 0f;
        }
    }
}
