using Assets;
namespace Runtime;

public static class Game
{
    private static Player s_Player;
    private static AssetRoot s_AssetRoot;

    private static LevelAsset s_CurrentLevel;
    public static Player Player => s_Player;
    public static AssetRoot AssetRoot => s_AssetRoot;
    public static LevelAsset LevelAsset=> s_CurrentLevel;

    public static void SetAssetRoot(AssetRoot assetRoot)
    {
        s_AssetRoot = assetRoot;
    }

    public static void StartLevel(LevelAsset levelAsset)
    {
      
        s_CurrentLevel = levelAsset;
        // Load scene
        s_Player = new Player();
    }
}
