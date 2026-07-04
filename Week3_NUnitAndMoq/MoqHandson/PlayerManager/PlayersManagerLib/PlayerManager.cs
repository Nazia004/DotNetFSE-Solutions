namespace PlayersManagerLib;

public class PlayerManager
{
    private readonly IPlayerMapper _playerMapper;

    public PlayerManager(IPlayerMapper playerMapper)
    {
        _playerMapper = playerMapper;
    }

    public bool RegisterNewPlayer(Player player)
    {
        return _playerMapper.AddPlayer(player);
    }
}