using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : ScriptableObject
{
    [SerializeField]
    private new string name;
    [SerializeField]
    private int damage;
    [SerializeField]
    private int magCapacity;
    [SerializeField]
    private float reloadTime;

    public string Name { get { return name; } }
    public int Damage { get { return damage; } }
    public int MagCapacity { get { return magCapacity; } }
    public float ReloadTime { get { return reloadTime; } }

    public abstract void Fire(Vector2 originPosition, float direction);
}
