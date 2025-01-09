using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Level level;
    public TMP_Text remainingText;
    public TMP_Text remainingSubtext;
    public TMP_Text targetText;
    public TMP_Text targetSubtext;
    public TMP_Text scoreText;

    public Image[] stars;
    private int starIndex;
    private bool isGameover;

    private void Start() {
        UpdateStars();
    }

    public void UpdateStars() {
        for(int i = 0; i < stars.Length; i++) {
            if(i == starIndex) {
                stars[i].enabled = true;
            } else {
                stars[i].enabled = false;
            }
        }
    }

    public void SetScore (int score) {
        scoreText.text = score.ToString();
        int visibleStar = 0;
        if (score >= level.score2Star && score < level.score3Star) {
            visibleStar = 1;
        } else if (score >= level.score2Star && score < level.score2Star) {
            visibleStar = 2;
        } else if (score >= level.score3Star) {
            visibleStar = 3;
        }
        starIndex = visibleStar;
        UpdateStars();
    }
    public void SetTarget(int target) {
        targetText.text = target.ToString();

    }

    public void SetRemaining(int remaining) {
        remainingText.text = remaining.ToString();

    }
    public void SetRemaining(string remaining) {
        remainingText.text = remaining;
    }

    public void SetLevelType(Level.LevelType type) {
        switch (type) {
            case Level.LevelType.MOVES:
                remainingSubtext.text = "Moves Remaining";
                targetSubtext.text = "Target Score";
                break;
            case Level.LevelType.OBSTACLE:
                remainingSubtext.text = "Moves Remaining";
                targetSubtext.text = "Dishes Remaining";
                break;
            case Level.LevelType.TIMER:
                remainingSubtext.text = "Time Remaining";
                targetSubtext.text = "Target Score";
                break;
        }
    }

     public void OnGameWin(int score) {
            isGameover = true;
      }

    public void OnGameLose() 
      {
            isGameover = false;
      }

    
    
    
}
    