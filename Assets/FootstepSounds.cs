using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSounds : MonoBehaviour
{
    public AudioSource footstepAudioSource;
    public AudioClip grassFootsteps;
    public AudioClip concreteFootsteps;
    public AudioClip indoorFootsteps;

    public CharacterController characterController;
    private PlayerTerrainDetector playerTerrainDetector;

    private void Start()
    {
        playerTerrainDetector = GetComponent<PlayerTerrainDetector>();
    }

    private void Update()
    {
        if (IsPlayerMoving())
        {
            string terrainType = playerTerrainDetector.GetCurrentTerrainType();
            switch (terrainType)
            {
                case "Indoor":
                    footstepAudioSource.clip = indoorFootsteps;
                    break;
                case "Grass":
                    footstepAudioSource.clip = grassFootsteps;
                    break;
                case "Concrete":
                    footstepAudioSource.clip = concreteFootsteps;
                    break;
            }

            if (!footstepAudioSource.isPlaying)
            {
                footstepAudioSource.Play();
            }
        }
        else
        {
            if (footstepAudioSource.isPlaying)
            {
                footstepAudioSource.Stop();
            }
        }
    }

    private bool IsPlayerMoving()
    {
        return characterController.velocity.magnitude > 0.1f;
    }
}
