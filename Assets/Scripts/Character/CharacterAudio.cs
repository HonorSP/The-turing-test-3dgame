﻿using UnityEngine;

/**
 * 
 * CharacterAudio - Handles the sounds the robot makes.
 */


public class CharacterAudio : MonoBehaviour
{
    public AudioSource jump;

    public void PlayJump()
    {
        if (Input.GetButtonDown("Jump"))
            jump.Play();
    }

    private void Update()
    {
        PlayJump();
    }
}
