using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFXPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip jumpSound;

    public void PlayJumpSound(Transform spawnTransform)
    {
        SoundFXManager.instance.PlaySound(jumpSound, spawnTransform, 0.5f);
    }
}
