// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchHistoryDetailView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200335A")]
  [FlowNode.Pin(101, "UnitToolTip", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(11, "ShamBattle", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(111, "OpenShamBattle", FlowNode.PinTypes.Output, 111)]
  public class LeagueMatchHistoryDetailView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400F272")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400F273")]
    private const int PIN_IN_SHAM_BATTLE = 11;
    [Token(Token = "0x400F274")]
    private const int PIN_OUTPUT_UNIT_TOOL_TIP = 101;
    [Token(Token = "0x400F275")]
    private const int PIN_OUTPUT_OPEN_SHAM_BTL = 111;
    [Token(Token = "0x400F276")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x400F277")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400F278")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400F279")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ExhibitList mMapExhibitList;
    [Token(Token = "0x400F27A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ContentExhibit mBuffContentExhibit;
    [Token(Token = "0x400F27B")]
    [FieldOffset(Offset = "0x1C")]
    private int mSeasonId;
    [Token(Token = "0x400F27C")]
    [FieldOffset(Offset = "0x20")]
    private LeagueMatchHistoryDetailModel mModels;
    [Token(Token = "0x400F27D")]
    [FieldOffset(Offset = "0x24")]
    private LeagueMatchMapModel mMapModel;
    [Token(Token = "0x400F27E")]
    [FieldOffset(Offset = "0x28")]
    private List<LeagueMatchBuffModel> mLeagueMatchBuffModels;
    [Token(Token = "0x400F27F")]
    [FieldOffset(Offset = "0x2C")]
    private JSON_LeagueMatchHistory mHistoryData;
    [Token(Token = "0x400F280")]
    [FieldOffset(Offset = "0x30")]
    private int mCurretPage;

    [Token(Token = "0x600E37D")]
    [Address(RVA = "0xAB5560", Offset = "0xAB4360", VA = "0x10AB5560", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600E37E")]
    [Address(RVA = "0xAB5710", Offset = "0xAB4510", VA = "0x10AB5710")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600E37F")]
    [Address(RVA = "0xAB5590", Offset = "0xAB4390", VA = "0x10AB5590")]
    private void InitBuffs(string[] buffs)
    {
    }

    [Token(Token = "0x600E380")]
    [Address(RVA = "0xAB62A0", Offset = "0xAB50A0", VA = "0x10AB62A0")]
    public void OpenUnitToolTip(UnitData unit)
    {
    }

    [Token(Token = "0x600E381")]
    [Address(RVA = "0xAB5C10", Offset = "0xAB4A10", VA = "0x10AB5C10")]
    private void OnSelectShamBattle()
    {
    }

    [Token(Token = "0x600E382")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchHistoryDetailView()
    {
    }
  }
}
