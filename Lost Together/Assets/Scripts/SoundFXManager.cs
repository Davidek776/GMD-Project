using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public static SoundFXManager instance;
    [SerializeField] private AudioSource soundFXObject;
    [SerializeField] private AudioClip buttonSelectSound;
    [SerializeField] private AudioClip buttonClickSound;
    private AudioSource jumpAudioSourcePlayer1;
    private AudioSource jumpAudioSourcePlayer2;

    private AudioSource runningAudioSourcePlayer1;
    private AudioSource runningAudioSourcePlayer2;

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

    public void PlayJumpSound(AudioClip clip, Transform spawnTransform, float volume, int playerIndex){
        if (playerIndex == 0)
            PlayJumpSoundPlayer1(clip, spawnTransform, volume);
        else
            PlayJumpSoundPlayer2(clip, spawnTransform, volume);
    }

    private void PlayJumpSoundPlayer1(AudioClip clip, Transform spawnTransform, float volume){
        if (jumpAudioSourcePlayer1 != null)
            return;

        jumpAudioSourcePlayer1 = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        jumpAudioSourcePlayer1.clip = clip;
        jumpAudioSourcePlayer1.volume = volume;
        jumpAudioSourcePlayer1.Play();
        float clipLength = clip.length;

        Destroy(jumpAudioSourcePlayer1.gameObject, clipLength);
    }

    private void PlayJumpSoundPlayer2(AudioClip clip, Transform spawnTransform, float volume){
        if (jumpAudioSourcePlayer2 != null)
            return;

        jumpAudioSourcePlayer2 = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        jumpAudioSourcePlayer2.clip = clip;
        jumpAudioSourcePlayer2.volume = volume;
        jumpAudioSourcePlayer2.Play();
        float clipLength = clip.length;

        Destroy(jumpAudioSourcePlayer2.gameObject, clipLength);
    }

    public void PlayRandomRunningSound(AudioClip[] clip, Transform spawnTransform, float volume, int playerIndex){
        if (playerIndex == 0)
            PlayRandomRunningSoundPlayer1(clip, spawnTransform, volume);
        else
            PlayRandomRunningSoundPlayer2(clip, spawnTransform, volume);
    }

    private void PlayRandomRunningSoundPlayer1(AudioClip[] clip, Transform spawnTransform, float volume){
        if (runningAudioSourcePlayer1 != null)
            return;

        runningAudioSourcePlayer1 = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        runningAudioSourcePlayer1.clip = clip[Random.Range(0, clip.Length)];
        runningAudioSourcePlayer1.volume = volume;
        runningAudioSourcePlayer1.Play();
        float clipLength = runningAudioSourcePlayer1.clip.length;

        Destroy(runningAudioSourcePlayer1.gameObject, clipLength);
    }

    private void PlayRandomRunningSoundPlayer2(AudioClip[] clip, Transform spawnTransform, float volume){
        if (runningAudioSourcePlayer2 != null)
            return;

        runningAudioSourcePlayer2 = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        runningAudioSourcePlayer2.clip = clip[Random.Range(0, clip.Length)];
        runningAudioSourcePlayer2.volume = volume;
        runningAudioSourcePlayer2.Play();
        float clipLength = runningAudioSourcePlayer2.clip.length;

        Destroy(runningAudioSourcePlayer2.gameObject, clipLength);
    }

    
    public void PlayButtonSelectSound()
    {
        PlaySound(buttonAudioSource, buttonSelectSound, soundFXObject.transform, 0.5f);
    }

    public void PlayButtonClickSound()
    {
        PlaySound(buttonAudioSource, buttonClickSound, soundFXObject.transform, 0.5f);
    }
}