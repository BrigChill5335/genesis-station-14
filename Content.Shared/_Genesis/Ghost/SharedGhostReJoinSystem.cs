using Content.Shared._Genesis.CCCVars;
using Robust.Shared.Configuration;
using Robust.Shared.Timing;

namespace Content.Shared._Genesis.Ghost;

public abstract class SharedGhostReJoinSystem : EntitySystem
{
    [Dependency] protected readonly IConfigurationManager _configurationManager = default!;
    [Dependency] protected readonly IGameTiming _gameTiming = default!;

    public override void Initialize()
    {
        base.Initialize();

        _configurationManager.OnValueChanged(CCVars.GhostRespawnTime,
            ghostRespawnTime =>
            {
                _ghostRespawnTime = TimeSpan.FromMinutes(ghostRespawnTime);
            },
            true);
    }

    protected TimeSpan _ghostRespawnTime = new(0, 30, 0);
}
