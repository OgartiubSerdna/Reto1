using UnityEngine;

public class MusicButton : MonoBehaviour
{
    public AudioSource audioSource;

    public void ToggleMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.Play();
        }
    }
}
