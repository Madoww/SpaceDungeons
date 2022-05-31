using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Projectile", menuName = "Ammo/Projectile")]
public class ProjectileData : ScriptableObject
{
    [SerializeField]
    private Color color;
    [SerializeField]
    private float speed;

    public Color Color { get { return color; } }
    public float Speed { get { return speed; } }
}
