using Unity.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   
    [SerializeField]
    private AudioClip flapSound;
    [SerializeField]
    private AudioClip scoreSound;
    [SerializeField]
    private AudioClip gameOverSound;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayFlapSound()
    {
        audioSource.PlayOneShot(flapSound);
    }
    public void PlayScoreSound() {
        audioSource.PlayOneShot(scoreSound);
    }
    public void PlayGameOverSound()
    {
        audioSource.PlayOneShot(gameOverSound);
    }
   

}
