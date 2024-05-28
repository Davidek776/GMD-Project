using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public static SoundFXManager instance;

    [Header("Sound FX Objects")]
    [SerializeField] private AudioSource soundFXObject;
    [SerializeField] private AudioClip buttonSelectSound;
    [SerializeField] private AudioClip buttonClickSound;

    [Header("Volumes")]
    [Range(0, 1)][SerializeField] private float jumpVolume = 0.75f;
    [Range(0, 1)][SerializeField] private float deathVolume = 0.75f;
    [Range(0, 1)][SerializeField] private float runningVolume = 1f;
    [Range(0, 1)][SerializeField] private float buttonVolume = 0.25f;

    private AudioSource jumpAudioSourcePlayer1;
    private AudioSource jumpAudioSourcePlayer2;
    private AudioSource runningAudioSourcePlayer1;
    private AudioSource runningAudioSourcePlayer2;
    private AudioSource deathAudioSourcePlayer1;
    private AudioSource deathAudioSourcePlayer2;
    private AudioSource buttonAudioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlaySound(AudioSource audioSource, AudioClip clip, Transform spawnTransform, float volume)
    {
        audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        audioSource.clip = clip;
        audioSource.volume = volume;
        audioSource.Play();
        float clipLength = clip.length;

        Destroy(audioSource.gameObject, clipLength);
    }

    public void PlayRandomJumpSound(AudioClip[] clip, Transform spawnTransform, int playerIndex)
    {
        if (playerIndex == 0)
            PlayRandomJumpSoundPlayer1(clip, spawnTransform, jumpVolume);
        else
            PlayRandomJumpSoundPlayer2(clip, spawnTransform, jumpVolume);
    }

    private void PlayRandomJumpSoundPlayer1(AudioClip[] clip, Transform spawnTransform, float volume)
    {
        if (jumpAudioSourcePlayer1 != null)
            return;

        jumpAudioSourcePlayer1 = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        jumpAudioSourcePlayer1.clip = clip[Random.Range(0, clip.Length)];
        jumpAudioSourcePlayer1.volume = volume;
        jumpAudioSourcePlayer1.Play();
        float clipLength = jumpAudioSourcePlayer1.clip.length;

        Destroy(jumpAudioSourcePlayer1.gameObject, clipLength);
    }

    private void PlayRandomJumpSoundPlayer2(AudioClip[] clip, Transform spawnTransform, float volume)
    {
        if (jumpAudioSourcePlayer2 != null)
            return;

        jumpAudioSourcePlayer2 = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        jumpAudioSourcePlayer2.clip = clip[Random.Range(0, clip.Length)];
        jumpAudioSourcePlayer2.volume = volume;
        jumpAudioSourcePlayer2.Play();
        float clipLength = jumpAudioSourcePlayer2.clip.length;

        Destroy(jumpAudioSourcePlayer2.gameObject, clipLength);
    }

    public void PlayRandomRunningSound(AudioClip[] clip, Transform spawnTransform, int playerIndex)
    {
        if (playerIndex == 0)
            PlayRandomRunningSoundPlayer1(clip, spawnTransform, runningVolume);
        else
            PlayRandomRunningSoundPlayer2(clip, spawnTransform, runningVolume);
    }

    private void PlayRandomRunningSoundPlayer1(AudioClip[] clip, Transform spawnTransform, float volume)
    {
        if (runningAudioSourcePlayer1 != null)
            return;

        runningAudioSourcePlayer1 = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        runningAudioSourcePlayer1.clip = clip[Random.Range(0, clip.Length)];
        runningAudioSourcePlayer1.volume = volume;
        runningAudioSourcePlayer1.Play();
        float clipLength = runningAudioSourcePlayer1.clip.length;

        Destroy(runningAudioSourcePlayer1.gameObject, clipLength);
    }

    private void PlayRandomRunningSoundPlayer2(AudioClip[] clip, Transform spawnTransform, float volume)
    {
        if (runningAudioSourcePlayer2 != null)
            return;

        runningAudioSourcePlayer2 = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        runningAudioSourcePlayer2.clip = clip[Random.Range(0, clip.Length)];
        runningAudioSourcePlayer2.volume = volume;
        runningAudioSourcePlayer2.Play();
        float clipLength = runningAudioSourcePlayer2.clip.length;

        Destroy(runningAudioSourcePlayer2.gameObject, clipLength);
    }

    public void PlayRandomDeathSound(AudioClip[] clip, Transform spawnTransform, int playerIndex)
    {
        if (playerIndex == 0)
            PlayRandomDeathSoundPlayer1(clip, spawnTransform, deathVolume);
        else
            PlayRandomDeathSoundPlayer2(clip, spawnTransform, deathVolume);
    }

    private void PlayRandomDeathSoundPlayer1(AudioClip[] clip, Transform spawnTransform, float volume)
    {
        if (deathAudioSourcePlayer1 != null)
            return;

        deathAudioSourcePlayer1 = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        deathAudioSourcePlayer1.clip = clip[Random.Range(0, clip.Length)];
        deathAudioSourcePlayer1.volume = volume;
        deathAudioSourcePlayer1.Play();
        float clipLength = deathAudioSourcePlayer1.clip.length;

        Destroy(deathAudioSourcePlayer1.gameObject, clipLength);
    }

    private void PlayRandomDeathSoundPlayer2(AudioClip[] clip, Transform spawnTransform, float volume)
    {
        if (deathAudioSourcePlayer2 != null)
            return;

        deathAudioSourcePlayer2 = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        deathAudioSourcePlayer2.clip = clip[Random.Range(0, clip.Length)];
        deathAudioSourcePlayer2.volume = volume;
        deathAudioSourcePlayer2.Play();
        float clipLength = deathAudioSourcePlayer2.clip.length;

        Destroy(deathAudioSourcePlayer2.gameObject, clipLength);
    }


    public void PlayButtonSelectSound()
    {
        PlaySound(buttonAudioSource, buttonSelectSound, soundFXObject.transform, buttonVolume);
    }

    public void PlayButtonClickSound()
    {
        PlaySound(buttonAudioSource, buttonClickSound, soundFXObject.transform, buttonVolume);
    }
}