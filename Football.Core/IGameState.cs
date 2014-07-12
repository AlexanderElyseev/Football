namespace Football.Core
{
    public interface IGameState
    {
        PlayerSpeed GetPlayerSpeed(Player player);

        PlayerPosition GetPlayerPosition(Player player);

        BallSpeed GetBallSpeed();

        BallPosition GetBallPosition();
    }
}