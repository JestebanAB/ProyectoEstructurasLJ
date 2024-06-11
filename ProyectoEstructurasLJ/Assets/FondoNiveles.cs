using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoNiveles : MonoBehaviour
{
    [SerializeField] private Vector2 movementVelocity;
    private Vector2 offset;
    private Material material;
    private Rigidbody2D player;

    private void Awake()
    {
        material= GetComponent<SpriteRenderer>().material;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (player != null)
        {
            offset = (player.velocity.x * 0.1f)*movementVelocity * Time.deltaTime;
            material.mainTextureOffset += offset;
        }
    }
}
