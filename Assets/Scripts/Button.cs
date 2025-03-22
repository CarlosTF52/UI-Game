using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField]
    private int _value;

    [SerializeField]
    private GameManager _gameManager;

    [SerializeField]
    private Image _coverImage;

    private void Start()
    {
        _gameManager = GameObject.Find("Manager").GetComponent<GameManager>();
    }

    public void SendScore()
    {
        _gameManager.ScoreTotal(_value);
        _coverImage.gameObject.SetActive(false);
    }
   
    
}
