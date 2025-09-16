using Content.Shared.Actions;
using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content._Genesis.Shared.Felinid;

[Serializable, NetSerializable]
public sealed partial class WoundLickingDoAfterEvent : SimpleDoAfterEvent
{
}

public sealed partial class WoundLickingActionEvent : EntityTargetActionEvent
{
}
