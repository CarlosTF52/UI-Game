using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _textField;

    [SerializeField]
    private int _score;

    [SerializeField]
    private GameObject[] _items;

    private GameObject _grid;

    [SerializeField]
    private int _maxScore;

    [SerializeField]
    private TextMeshProUGUI _maxScoreText;

    

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Main Menu Scene")
        {
            _maxScore = PlayerPrefs.GetInt("MaxScore");
            _maxScoreText.text = _maxScore.ToString();
        }

        if(SceneManager.GetActiveScene().name == "Game 1 Scene")
        {
            _textField.text = "0";
            _score = 0;
            _grid = GameObject.Find("Grid");

            for (int i = 0; i < 15; i++)
            {
                GameObject item = Instantiate(_items[Random.Range(0, 3)], transform.position, Quaternion.identity);
                item.transform.SetParent(_grid.transform);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreTotal(int value)
    {
        _score += value;
        _textField.text = _score.ToString();
        PlayerPrefs.SetInt("MaxScore", _score);
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("MaxScore");
        _maxScore = PlayerPrefs.GetInt("MaxScore");
        _maxScoreText.text = _maxScore.ToString();
    }

    public void ExitGame()
    {
        Application.Quit();
    }


    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void StartGame2()
    {
        SceneManager.LoadScene(2);
    }

    public void StartGame3()
    {
        SceneManager.LoadScene(3);
    }

}
