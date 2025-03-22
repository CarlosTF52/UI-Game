using UnityEngine;
using TMPro;  // Namespace for TextMesh Pro

public class ClickerGame : MonoBehaviour
{
    public TMP_Text scoreText;  
    public TMP_Text upgradeCostText;  
    public UnityEngine.UI.Button upgradeButton;
    public UnityEngine.UI.Button clickButton;  

    private int score = 0; 
    private int pointsPerClick = 1; 
    private int upgradeCost = 10;
    private int maxScore;

    void Start()
    {
       
        UpdateScoreDisplay();
        UpdateUpgradeCostDisplay();
    }

   
    public void OnClick()
    {
        score += pointsPerClick;  
        UpdateScoreDisplay();  
    }

    
    public void PurchaseUpgrade()
    {
        if (score >= upgradeCost)
        {
            score -= upgradeCost; 
            pointsPerClick++;  

            
            upgradeCost = Mathf.CeilToInt(upgradeCost * 1.5f);  

           
            UpdateScoreDisplay();
            UpdateUpgradeCostDisplay();
        }
    }

   
    void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score.ToString();
        PlayerPrefs.SetInt("MaxScore", maxScore);
    }

    
    void UpdateUpgradeCostDisplay()
    {
        upgradeCostText.text = "Upgrade Cost: " + upgradeCost.ToString();
    }
}
