using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterMovement), typeof(FOVTopDown))]
public class EnermyAIController : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    private CharacterMovement _characterMovement;
    private FOVTopDown _fov;

    private void Awake()
    {
        _characterMovement = GetComponent<CharacterMovement>();
        _fov = GetComponent<FOVTopDown>();
    }

    private void Update()
    {
        if (_fov.CanSeeTarget(player?.transform))
        {
            var toPlayer = (player.transform.position - transform.position).normalized;
            _characterMovement.SetInput(toPlayer.x, toPlayer.y);
        }
        else
        {
            _characterMovement.SetInput(0, 0);
        }
    }
}
