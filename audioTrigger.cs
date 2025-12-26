using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioClip clip;

    public void Play()
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.PlaySFX(clip);
        }
    }
}
