#if UNITY_EDITOR

using System.Linq;

using UnityEditor;

public static class BuildScript
{
    [MenuItem("Build/Windows")]
    public static void BuildWindows()
    {
        var options = new BuildPlayerOptions()
        {
            locationPathName = "builds/Windows/CI-CD.exe",
            scenes = GetDefaultScenePaths(),

            options = BuildOptions.ShowBuiltPlayer,

            targetGroup = BuildTargetGroup.Standalone,
            target = BuildTarget.StandaloneWindows64,
        };

        BuildPipeline.BuildPlayer(options);
    }

    static string[] GetDefaultScenePaths()
    {
        return EditorBuildSettings.scenes
            .Select(x => x.path)
            .ToArray();
    }
}
#endif