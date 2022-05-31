using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Projectile Weapon", menuName = "Weapon/Projectile Weapon")]
public class ProjectileWeapon : Weapon
{
    [SerializeField]
    private Projectile projectile;

    public override void Fire(Vector2 originPosition, float direction)
    {
        Debug.Log("Projectile weapon fired!");
        Projectile firedProjectile = Instantiate(projectile);
        firedProjectile.transform.position = originPosition;
        firedProjectile.SetDirection(new Vector2(Mathf.Cos(direction), Mathf.Sin(direction)));
    }
}
