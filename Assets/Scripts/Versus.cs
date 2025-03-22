using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Versus : MonoBehaviour
{
    [SerializeField]
    private Drop _leftDrop;

    [SerializeField]
    private Drop _rightDrop;

    [SerializeField]
    private GameObject _soldierWins;

    [SerializeField]
    private GameObject _mageWins;

    [SerializeField]
    private GameObject _wolfWins;

    [SerializeField]
    private GameObject _gameSpace;

    [SerializeField]
    private GameObject _mainmenuButton;

    [SerializeField]
    private GameObject _resetSceneButton;



    public void CalculateVersus()
    {
        if(_leftDrop._class != "" && _rightDrop._class != "")
        {
            _gameSpace.SetActive(false);

            _mainmenuButton.SetActive(true);

            _resetSceneButton.SetActive(true);

        }

        if (_leftDrop._class == "Soldier" && _rightDrop._class == "Mage")
        {
            _mageWins.SetActive(true);
        }

        if (_leftDrop._class == "Soldier" && _rightDrop._class == "Wolf")
        {
            _soldierWins.SetActive(true);
        }

        if (_leftDrop._class == "Mage" && _rightDrop._class == "Soldier")
        {
            _mageWins.SetActive(true);
        }

        if (_leftDrop._class == "Mage" && _rightDrop._class == "Wolf")
        {
            _wolfWins.SetActive(true);
        }

        if (_leftDrop._class == "Mage" && _rightDrop._class == "Mage")
        {
            _mageWins.SetActive(true);
        }

        if (_leftDrop._class == "Wolf" && _rightDrop._class == "Mage")
        {
            _wolfWins.SetActive(true);
        }

        if (_leftDrop._class == "Wolf" && _rightDrop._class == "Soldier")
        {
            _soldierWins.SetActive(true);
        }

    }

}
