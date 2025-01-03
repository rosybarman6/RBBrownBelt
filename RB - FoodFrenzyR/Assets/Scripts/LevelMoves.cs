﻿public class LevelMoves : Level
{
    public int numMoves;
    public int targetScore;

    private int movesUsed = 0;

    // Start is called before the first frame update
    void Start()
    {
        type = LevelType.MOVES;


        hud.SetLevelType(type);
        hud.SetScore(currentScore);
        hud.SetTarget(targetScore);
        hud.SetRemaining(numMoves);

    }

    public override void OnMove()
    {
        base.OnMove();

        movesUsed++;

        hud.SetRemaining(numMoves - movesUsed);

        if(numMoves - movesUsed == 0)
        {
            if(currentScore >= targetScore)
            {
                GameWin();
            }
            else
            {
                GameLose();
            }
        }
    }

    
}
