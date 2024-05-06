using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundMixerManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    private void Start()
    {
        if (PlayerPrefs.HasKey("masterVolume"))
        {
            SetMasterVolume(PlayerPrefs.GetFloat("masterVolume"));
        }
        if (PlayerPrefs.HasKey("soundEffectsVolume"))
        {
            SetSoundEffectsVolume(PlayerPrefs.GetFloat("soundEffectsVolume"));
        }
        if (PlayerPrefs.HasKey("backgroundMusicVolume"))
        {
            SetBackgroundMusicVolume(PlayerPrefs.GetFloat("backgroundMusicVolume"));
        }
    }

    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("masterVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("masterVolume", volume);
    }

    public void SetSoundEffectsVolume(float volume)
    {
        audioMixer.SetFloat("soundEffectsVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("soundEffectsVolume", volume);
    }

    public void SetBackgroundMusicVolume(float volume)
    {
        audioMixer.SetFloat("backgroundMusicVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("backgroundMusicVolume", volume);
    }
}
