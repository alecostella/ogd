/*
    Constant parameters used throughout the game.
*/

public class Const
{
    // Game grid
    public static readonly int Rows = 6;
    public static readonly int Columns = 6;

    // Animations
    public static readonly float AnimationDuration = 0.1f;
    public static readonly float MoveAnimationMinDuration = 0.125f;
    public static readonly float CollapseDelay = 0.35f;
    public static readonly float ExplosionDuration = 0.3f;
    public static readonly float WaitBeforePotentialMatchesCheck = 2f;
    public static readonly float OpacityAnimationFrameDelay = 0.05f;

    // Logic
    public static readonly int MinimumMatches = 3;
    public static readonly int MinimumMatchesForBonus = 4;

    // Scoring
    public static readonly int Match3Score = 30;
    public static readonly int SubsequentMatchScore = 100;
    public static readonly int BombScore = 150;
    public static readonly int ScoreThreshold = 1200;

    // Fonts
    public static readonly int TimeTextSize = 100;
    public static readonly int ScoreTextSize = 70;
    public static readonly int MovesTextSize = 65;
    public static readonly int ComboTextSize = 135;
    public static readonly int CountdownTextSize = 220;
}
