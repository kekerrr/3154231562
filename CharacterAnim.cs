using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator animationMage;
    private int isWalkingHash, isRunningHash;

    private void Start()
    {
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    private void Update()
    {
        bool isRunning = animationMage.GetBool(isRunningHash);
        bool isWalking = animationMage.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        if (!isWalking && forwardPressed)
        {
            animationMage.SetBool("isWalking", true);
        }
        if (isWalking && !forwardPressed)
        {
            animationMage.SetBool("isWalking", false);
        }
        if (!isRunning && forwardPressed && runPressed)
        {
            animationMage.SetBool("isRunning", true);
        }
        if (isRunning && (!forwardPressed || !runPressed))
        {
            animationMage.SetBool("isRunning", false);
        }


    }
}