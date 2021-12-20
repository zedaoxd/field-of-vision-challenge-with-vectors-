using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
public class CharacterAnimatorController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private CharacterMovement _characterMovement;

    private void Awake()
    {
        _characterMovement = GetComponent<CharacterMovement>();
    }

    private void LateUpdate()
    {
        var speedPercent = _characterMovement.Velocity.sqrMagnitude /
                           (_characterMovement.MaxSpeed * _characterMovement.MaxSpeed);
        animator.SetFloat("Speed", speedPercent);
    }
}
