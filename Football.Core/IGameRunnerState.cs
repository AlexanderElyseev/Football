namespace Football.Core
{
    public interface IGameRunnerState
    {
        PlayerSpeed GetPlayerSpeed(Player player);

        PlayerPosition GetPlayerPosition(Player player);

        BallSpeed GetBallSpeed();

        BallPosition GetBallPosition();
    }
}