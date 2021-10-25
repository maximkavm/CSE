using Assets;
namespace Runtime;

public static class Game
{
    private static Player s_Player;
    private static AssetRoot s_AssetRoot;
    public static Player Player => s_Player;
    public static AssetRoot AssetRoot => s_AssetRoot;
}
