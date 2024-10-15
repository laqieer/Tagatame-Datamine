// Decompiled with JetBrains decompiler
// Type: SRPG.GvGPresetPartyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002609")]
  [AddComponentMenu("UI/GvG/GvGPresetPartyWindow")]
  [FlowNode.Pin(2202, "全チーム解散", FlowNode.PinTypes.Input, 2202)]
  [FlowNode.Pin(2102, "チーム名の変更", FlowNode.PinTypes.Output, 2102)]
  [FlowNode.Pin(2101, "個別編成データの保存", FlowNode.PinTypes.Output, 2101)]
  [FlowNode.Pin(2201, "チーム解散", FlowNode.PinTypes.Input, 2201)]
  [FlowNode.Pin(2204, "全チーム解散実行", FlowNode.PinTypes.Output, 2204)]
  [FlowNode.Pin(2203, "チーム解散実行", FlowNode.PinTypes.Output, 2203)]
  [FlowNode.Pin(2001, "ユニットリストを閉じる", FlowNode.PinTypes.Input, 2001)]
  public class GvGPresetPartyWindow : PartyWindow2
  {
    [Token(Token = "0x400B10E")]
    private const int GVG_SAVE_UNITLISTCLOSE_INPUT = 2001;
    [Token(Token = "0x400B10F")]
    private const int GVG_SAVE_OVERWRITE_OUTPUT = 2101;
    [Token(Token = "0x400B110")]
    private const int GVG_SAVE_OVERWRITENAME_OUTPUT = 2102;
    [Token(Token = "0x400B111")]
    private const int GVG_TEAM_DISBAND_INPUT = 2201;
    [Token(Token = "0x400B112")]
    private const int GVG_ALL_TEAM_DISBAND_INTPUT = 2202;
    [Token(Token = "0x400B113")]
    private const int GVG_TEAM_DISBAND_OUTPUT = 2203;
    [Token(Token = "0x400B114")]
    private const int GVG_ALL_TEAM_DISBAND_OUTPUT = 2204;
    [Token(Token = "0x400B115")]
    [FieldOffset(Offset = "0x2D4")]
    [SerializeField]
    private SRPG_Button mTeamDisbandBtn;
    [Token(Token = "0x400B116")]
    [FieldOffset(Offset = "0x2D8")]
    [SerializeField]
    private SRPG_Button mAllTeamDisbandBtn;

    [Token(Token = "0x600A985")]
    [Address(RVA = "0x6CCFD0", Offset = "0x6CBDD0", VA = "0x106CCFD0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A986")]
    [Address(RVA = "0x6CD860", Offset = "0x6CC660", VA = "0x106CD860", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600A987")]
    [Address(RVA = "0x6CCB70", Offset = "0x6CB970", VA = "0x106CCB70", Slot = "32")]
    public override void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A988")]
    [Address(RVA = "0x6CC510", Offset = "0x6CB310", VA = "0x106CC510", Slot = "14")]
    protected override void SetItemSlot(int slotIndex, ItemData item)
    {
    }

    [Token(Token = "0x600A989")]
    [Address(RVA = "0x6CD0C0", Offset = "0x6CBEC0", VA = "0x106CD0C0")]
    private List<PartyEditData> LoadGvGPresets(
      PartyWindow2.EditPartyTypes edit_party_type,
      out int lastSelectionIndex)
    {
      return (List<PartyEditData>) null;
    }

    [Token(Token = "0x600A98A")]
    [Address(RVA = "0x6CD590", Offset = "0x6CC390", VA = "0x106CD590", Slot = "29")]
    protected override void LoadTeam(PartyWindow2.EditPartyTypes edit_party_type)
    {
    }

    [Token(Token = "0x600A98B")]
    [Address(RVA = "0x6CE0E0", Offset = "0x6CCEE0", VA = "0x106CE0E0", Slot = "27")]
    protected override void SaveTeamPresets()
    {
    }

    [Token(Token = "0x600A98C")]
    [Address(RVA = "0x6CE260", Offset = "0x6CD060", VA = "0x106CE260", Slot = "11")]
    protected override bool TeamChangeImpl(PartyEditData party) => new bool();

    [Token(Token = "0x600A98D")]
    [Address(RVA = "0x6CE150", Offset = "0x6CCF50", VA = "0x106CE150", Slot = "15")]
    protected override void SetPartyUnit(
      int slotIndex,
      UnitData unit,
      bool isSlotChange = true,
      bool edit_party_only = false,
      bool isSwap = false)
    {
    }

    [Token(Token = "0x600A98E")]
    [Address(RVA = "0x6CDEF0", Offset = "0x6CCCF0", VA = "0x106CDEF0")]
    private void SaveGvGPresetParty()
    {
    }

    [Token(Token = "0x600A98F")]
    [Address(RVA = "0x6CD920", Offset = "0x6CC720", VA = "0x106CD920", Slot = "21")]
    protected override void OnForwardOrBackButtonClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600A990")]
    [Address(RVA = "0x6CE630", Offset = "0x6CD430", VA = "0x106CE630", Slot = "37")]
    protected override void UnitList_OnSelect_RefreshOverWrite(UnitData selected_unit)
    {
    }

    [Token(Token = "0x600A991")]
    [Address(RVA = "0x6CDDE0", Offset = "0x6CCBE0", VA = "0x106CDDE0", Slot = "34")]
    public override void Reopen(bool farceRefresh = false)
    {
    }

    [Token(Token = "0x600A992")]
    [Address(RVA = "0x6CE7C0", Offset = "0x6CD5C0", VA = "0x106CE7C0")]
    private void UpdeteTeamDisbandBtn()
    {
    }

    [Token(Token = "0x600A993")]
    [Address(RVA = "0x6CE290", Offset = "0x6CD090", VA = "0x106CE290")]
    private void TeamDisband()
    {
    }

    [Token(Token = "0x600A994")]
    [Address(RVA = "0x6CE180", Offset = "0x6CCF80", VA = "0x106CE180")]
    private void TeamAllDisband()
    {
    }

    [Token(Token = "0x600A995")]
    [Address(RVA = "0x439930", Offset = "0x438730", VA = "0x10439930")]
    public GvGPresetPartyWindow()
    {
    }
  }
}
