using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    public static audiomanager instance; 
    [SerializeField] private AudioClip _gameOverSound;
    private AudioSource _audioSource;

    private void Awake()
    {
        if (instance ==null)
        {
            instance = this; 
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        _audioSource = GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
        GameEvents.OnGameOver += OnGameOver; 
    }

    private void OnDisable()
    {
        GameEvents.OnGameOver -= OnGameOver; 
    }
    private void OnGameOver()
    {
        _audioSource.PlayOneShot(_gameOverSound);
    }
}
