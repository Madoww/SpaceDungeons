using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private ProjectileData projectileData;

    [SerializeField]
    private SpriteRenderer sprite;

    private Vector2 normalizedFlyingDirection;

    private void OnEnable()
    {
        sprite.color = projectileData.Color;
    }

    private void Update()
    {
        transform.position += new Vector3(normalizedFlyingDirection.x * projectileData.Speed * Time.deltaTime, normalizedFlyingDirection.y * projectileData.Speed * Time.deltaTime, 0);
    }

    public void SetDirection(Vector2 direction)
    {
        normalizedFlyingDirection = direction.normalized;
    }
}
