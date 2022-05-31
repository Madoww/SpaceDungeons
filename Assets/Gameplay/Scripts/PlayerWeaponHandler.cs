using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeaponHandler : MonoBehaviour
{
    [SerializeField]
    private Weapon weapon;

    private Player player;

    private void Start()
    {
        InputController.Instance.PlayerActions.Fire.performed += Fire;
    }

    public void Initialize(Player player)
    {
        this.player = player;
    }

    private void Fire(InputAction.CallbackContext context)
    {
        float rotation = transform.rotation.eulerAngles.z;
        weapon.Fire(transform.position, player.RotationRadian);
    }
}
