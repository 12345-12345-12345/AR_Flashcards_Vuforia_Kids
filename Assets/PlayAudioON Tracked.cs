using UnityEngine;
using UnityEngine.UI;

public class PlayAudioOnButton : MonoBehaviour
{
    public AudioClip audioClip; // Assign in Inspector
    private AudioSource audioSource;
    public Button playButton; // Assign your UI Button in Inspector

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        if (playButton != null)
        {
            playButton.onClick.AddListener(PlayTheSound);
        }
    }

    void PlayTheSound()
    {
        if (audioClip != null && audioSource != null && !audioSource.isPlaying)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}