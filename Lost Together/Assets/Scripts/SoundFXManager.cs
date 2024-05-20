using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public static SoundFXManager instance;
    [SerializeField] private AudioSource soundFXObject;
    [SerializeField] private AudioClip buttonSelectSound;
    [SerializeField] private AudioClip buttonClickSound;
    private AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlaySound(AudioClip clip, Transform spawnTransform, float volume)
    {
        audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        audioSource.clip = clip;
        audioSource.volume = volume;
        audioSource.Play();
        float clipLength = clip.length;

        Destroy(audioSource.gameObject, clipLength);
    }

    public void PlayRandomSound(AudioClip[] clip, Transform spawnTransform, float volume)
    {
        int randomIndex = Random.Range(0, clip.Length);

        audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        audioSource.clip = clip[randomIndex];
        audioSource.volume = volume;
        audioSource.Play();
        float clipLength = audioSource.clip.length;

        Destroy(audioSource.gameObject, clipLength);
    }

    public void PlayJumpSound(AudioClip clip, Transform spawnTransform, float volume){
        if (audioSource != null)
            return;

        PlaySound(clip, spawnTransform, volume);
    }

    public void PlayRandomJumpSound(AudioClip[] clip, Transform spawnTransform, float volume){
        if (audioSource != null)
            return;

        PlayRandomSound(clip, spawnTransform, volume);
    }

    public void PlayButtonSelectSound()
    {
        PlaySound(buttonSelectSound, soundFXObject.transform, 0.5f);
    }

    public void PlayButtonClickSound()
    {
        PlaySound(buttonClickSound, soundFXObject.transform, 0.5f);
    }
}