using Content.Shared._Genesis.Ghost;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;
namespace Content.Client._Genesis.Ghost.UI;
[GenerateTypedNameReferences]
public sealed partial class GhostReJoinSelect : DefaultWindow
{
    public event EventHandler<(NetEntity station, int character)> OnRejoinSelectSelected = delegate { };
    public event EventHandler<NetEntity> OnRejoinSelectRandom = delegate { };
    private Dictionary<int, GhostReJoinCharacter> CharacterDictionary { get; } = new();
    private Dictionary<int, GhostReJoinStation> StationDictionary { get; } = new();
    public GhostReJoinSelect()
    {
        RobustXamlLoader.Load(this);
        UseRandomCharacter.OnPressed += UseRandomCharacterClick;
        UseSelectedCharacter.OnPressed += UseSelectedCharacterClick;
        StationSelect.OnItemSelected += StationSelectOnOnItemSelected;
        CharacterSelect.OnItemSelected += CharacterSelectOnOnItemSelected;
    }
    private void CharacterSelectOnOnItemSelected(OptionButton.ItemSelectedEventArgs obj)
    {
        CharacterSelect.SelectId(obj.Id);
    }
    private void StationSelectOnOnItemSelected(OptionButton.ItemSelectedEventArgs obj)
    {
        StationSelect.SelectId(obj.Id);
    }
    private void UseSelectedCharacterClick(BaseButton.ButtonEventArgs obj)
    {
        if(StationSelect.SelectedId < 0 || !StationDictionary.TryGetValue(StationSelect.SelectedId, out var station))
            return;
        if(CharacterSelect.SelectedId < 0 || !CharacterDictionary.TryGetValue(CharacterSelect.SelectedId, out var character))
            return;
        OnRejoinSelectSelected.Invoke(this, (station.Station, character.Id));
    }
    private void UseRandomCharacterClick(BaseButton.ButtonEventArgs obj)
    {
        if(StationSelect.SelectedId < 0 || !StationDictionary.TryGetValue(StationSelect.SelectedId, out var station))
            return;
        OnRejoinSelectRandom.Invoke(this, station.Station);
    }
    public void UpdateState(GhostReJoinInterfaceState state)
    {
        StationSelect.Clear();
        StationDictionary.Clear();
        var idx = 0;
        foreach (var joinStation in state.Stations)
        {
            StationDictionary.Add(idx, joinStation);
            StationSelect.AddItem(joinStation.Name, idx);
            idx++;
        }
        CharacterSelect.Clear();
        CharacterDictionary.Clear();
        idx = 0;
        foreach (var joinChar in state.Characters)
        {
            CharacterDictionary.Add(idx, joinChar);
            CharacterSelect.AddItem(joinChar.Name, idx);
            idx++;
        }
    }
}
