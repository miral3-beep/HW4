using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlying : MonoBehaviour
{
   [SerializeField] private float velocity = 1.5f;
   [SerializeField] private float _rotationSpeed = 10f;
   [SerializeField] private AudioClip _jumpSound;
   private Rigidbody2D _rb;
   private AudioSource _audioSource; 

   private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, 4.0f);
            _audioSource.PlayOneShot(_jumpSound);
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.instance.GameOver();
    }
}
