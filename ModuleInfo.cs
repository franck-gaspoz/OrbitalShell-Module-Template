using OrbitalShell.Component.Shell.Module;
using OrbitalShell.Lib;

/// <summary>
/// declare a shell module
/// </summary>
[assembly: ShellModule()]
[assembly: ModuleTargetPlateform(TargetPlatform.Any)]
[assembly: ModuleShellMinVersion(ModuleMinShellVersion)]
[assembly: ModuleAuthors({ModuleAuthors})]
namespace OrbitalShell.Module.PromptGitInfo
{
    public class ModuleInfo { }
}