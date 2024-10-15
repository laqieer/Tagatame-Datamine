// Decompiled with JetBrains decompiler
// Type: SRPG.GvGPartyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002605")]
  [FlowNode.Pin(2001, "キャッシュを削除", FlowNode.PinTypes.Input, 2001)]
  [FlowNode.Pin(2010, "GvGチーム名変更完了", FlowNode.PinTypes.Input, 2010)]
  [FlowNode.Pin(2100, "GvGチーム変更", FlowNode.PinTypes.Output, 2100)]
  [AddComponentMenu("UI/GvG/GvGPartyWindow")]
  public class GvGPartyWindow : PartyWindow2
  {
    [Token(Token = "0x400B0F4")]
    private const int GVG_DELETE_CACHE = 2001;
    [Token(Token = "0x400B0F5")]
    private const int GVG_PRESET_NAMECHANGE = 2010;
    [Token(Token = "0x400B0F6")]
    private const int GVG_SAVE_OVERWRITE = 2100;
    [Token(Token = "0x400B0F7")]
    private const int GVG_OVERWRITE_PARTYNUM = 0;
    [Token(Token = "0x400B0F8")]
    [FieldOffset(Offset = "0x2D4")]
    [SerializeField]
    private Text NodeName;
    [Token(Token = "0x400B0F9")]
    [FieldOffset(Offset = "0x2D8")]
    [SerializeField]
    private Text GoText;
    [Token(Token = "0x400B0FA")]
    [FieldOffset(Offset = "0x2DC")]
    [SerializeField]
    private string HPBarObjectName;
    [Token(Token = "0x400B0FB")]
    [FieldOffset(Offset = "0x2E0")]
    [SerializeField]
    private string DeadObjectName;
    [Token(Token = "0x400B0FC")]
    [FieldOffset(Offset = "0x2E4")]
    [SerializeField]
    private bool SetPartyUnitsClear;
    [Token(Token = "0x400B0FD")]
    [FieldOffset(Offset = "0x2E8")]
    private List<UnitData> Units;
    [Token(Token = "0x400B0FE")]
    [FieldOffset(Offset = "0x2EC")]
    [SerializeField]
    private FixedScrollablePulldown GvGTeamPulldown;
    [Token(Token = "0x400B0FF")]
    [FieldOffset(Offset = "0x2F0")]
    [SerializeField]
    private Text GvGTeamPulldownText;
    [Token(Token = "0x400B100")]
    [FieldOffset(Offset = "0x2F4")]
    [SerializeField]
    private List<Button> ConsecutiveWinsButton;
    [Token(Token = "0x400B101")]
    [FieldOffset(Offset = "0x2F8")]
    [SerializeField]
    private Slider StaminaSlider;
    [Token(Token = "0x400B102")]
    [FieldOffset(Offset = "0x2FC")]
    [SerializeField]
    private ImageArray StaminaImageArray;
    [Token(Token = "0x400B103")]
    [FieldOffset(Offset = "0x300")]
    [SerializeField]
    private GameObject UnitLockObject;
    [Token(Token = "0x400B104")]
    [FieldOffset(Offset = "0x304")]
    private GvGNodeData CurrentNode;

    [Token(Token = "0x170017DD")]
    private bool isConsecutiveWins
    {
      [Token(Token = "0x600A95E"), Address(RVA = "0x6CCA80", Offset = "0x6CB880", VA = "0x106CCA80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A95F")]
    [Address(RVA = "0x6C8750", Offset = "0x6C7550", VA = "0x106C8750")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A960")]
    [Address(RVA = "0x6C96F0", Offset = "0x6C84F0", VA = "0x106C96F0")]
    private void Destroy()
    {
    }

    [Token(Token = "0x600A961")]
    [Address(RVA = "0x6C7D90", Offset = "0x6C6B90", VA = "0x106C7D90", Slot = "32")]
    public override void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A962")]
    [Address(RVA = "0x6CBCF0", Offset = "0x6CAAF0", VA = "0x106CBCF0")]
    private void ReloadPartyUnits()
    {
    }

    [Token(Token = "0x600A963")]
    [Address(RVA = "0x6CC510", Offset = "0x6CB310", VA = "0x106CC510", Slot = "14")]
    protected override void SetItemSlot(int slotIndex, ItemData item)
    {
    }

    [Token(Token = "0x600A964")]
    [Address(RVA = "0x6CC4A0", Offset = "0x6CB2A0", VA = "0x106CC4A0", Slot = "27")]
    protected override void SaveTeamPresets()
    {
    }

    [Token(Token = "0x600A965")]
    [Address(RVA = "0x6CC200", Offset = "0x6CB000", VA = "0x106CC200")]
    private void SaveGvGPresetParty()
    {
    }

    [Token(Token = "0x600A966")]
    [Address(RVA = "0x6C8950", Offset = "0x6C7750", VA = "0x106C8950", Slot = "16")]
    protected override void BeforeSetPartyUnit()
    {
    }

    [Token(Token = "0x600A967")]
    [Address(RVA = "0x6CA820", Offset = "0x6C9620", VA = "0x106CA820", Slot = "21")]
    protected override void OnForwardOrBackButtonClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600A968")]
    [Address(RVA = "0x6C9ED0", Offset = "0x6C8CD0", VA = "0x106C9ED0")]
    private List<PartyEditData> LoadGvGPresets(out int lastSelectionIndex)
    {
      return (List<PartyEditData>) null;
    }

    [Token(Token = "0x600A969")]
    [Address(RVA = "0x6CA4F0", Offset = "0x6C92F0", VA = "0x106CA4F0", Slot = "29")]
    protected override void LoadTeam(PartyWindow2.EditPartyTypes edit_party_type)
    {
    }

    [Token(Token = "0x600A96A")]
    [Address(RVA = "0x6CC890", Offset = "0x6CB690", VA = "0x106CC890", Slot = "28")]
    protected override void SetUnitOverWriteTeams(PartyWindow2.EditPartyTypes edit_party_type)
    {
    }

    [Token(Token = "0x600A96B")]
    [Address(RVA = "0x6CB4A0", Offset = "0x6CA2A0", VA = "0x106CB4A0", Slot = "30")]
    protected override void OverrideLoadTeam()
    {
    }

    [Token(Token = "0x600A96C")]
    [Address(RVA = "0x6CB220", Offset = "0x6CA020", VA = "0x106CB220", Slot = "9")]
    protected override void OnNextTeamChange()
    {
    }

    [Token(Token = "0x600A96D")]
    [Address(RVA = "0x6CB300", Offset = "0x6CA100", VA = "0x106CB300", Slot = "10")]
    protected override void OnPrevTeamChange()
    {
    }

    [Token(Token = "0x600A96E")]
    [Address(RVA = "0x6CA3A0", Offset = "0x6C91A0", VA = "0x106CA3A0")]
    private void LoadPresetTeam()
    {
    }

    [Token(Token = "0x600A96F")]
    [Address(RVA = "0x6CB180", Offset = "0x6C9F80", VA = "0x106CB180")]
    private void OnGvGPresetTeamChange(int index)
    {
    }

    [Token(Token = "0x600A970")]
    [Address(RVA = "0x6CBB50", Offset = "0x6CA950", VA = "0x106CBB50", Slot = "23")]
    protected override void PostForwardPressed()
    {
    }

    [Token(Token = "0x600A971")]
    [Address(RVA = "0x6CB3E0", Offset = "0x6CA1E0", VA = "0x106CB3E0", Slot = "18")]
    protected override void OnUnitSlotClick(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600A972")]
    [Address(RVA = "0x6CC140", Offset = "0x6CAF40", VA = "0x106CC140", Slot = "34")]
    public override void Reopen(bool farceRefresh = false)
    {
    }

    [Token(Token = "0x600A973")]
    [Address(RVA = "0x6C9520", Offset = "0x6C8320", VA = "0x106C9520")]
    private bool CheckUsedUnit() => new bool();

    [Token(Token = "0x600A974")]
    [Address(RVA = "0x6CC580", Offset = "0x6CB380", VA = "0x106CC580")]
    private void SetRemoveUsedItem()
    {
    }

    [Token(Token = "0x600A975")]
    [Address(RVA = "0x6C9130", Offset = "0x6C7F30", VA = "0x106C9130")]
    private bool CheckUsedItem() => new bool();

    [Token(Token = "0x600A976")]
    [Address(RVA = "0x6C9210", Offset = "0x6C8010", VA = "0x106C9210")]
    private bool CheckUsedUnitCount(bool is_check_slot) => new bool();

    [Token(Token = "0x600A977")]
    [Address(RVA = "0x6C9730", Offset = "0x6C8530", VA = "0x106C9730")]
    private void DuplicateNotifyRemoveItem(int select)
    {
    }

    [Token(Token = "0x600A978")]
    [Address(RVA = "0x6CCA00", Offset = "0x6CB800", VA = "0x106CCA00")]
    public GvGPartyWindow()
    {
    }
  }
}
