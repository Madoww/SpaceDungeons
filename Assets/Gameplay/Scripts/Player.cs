using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private PlayerMovementController playerMovementController;

    [SerializeField]
    private PlayerWeaponHandler playerWeaponHandler;

    public float RotationRadian { get; set; }

    private void Start()
    {
        playerMovementController.Initialize(this);
        playerWeaponHandler.Initialize(this);
    }
}
