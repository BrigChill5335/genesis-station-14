using Robust.Shared.Configuration;

namespace Content.Shared._Genesis.CCVar;

// ReSharper disable once InconsistentNaming
[CVarDefs]
public sealed class CCVars
{
    /*
     * Ghost Respawn
     */

    public static readonly CVarDef<float> GhostRespawnTime =
        CVarDef.Create("ghost.respawn_time", 15f, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<int> GhostRespawnMaxPlayers =
        CVarDef.Create("ghost.respawn_max_players", 40, CVar.SERVERONLY);

}
