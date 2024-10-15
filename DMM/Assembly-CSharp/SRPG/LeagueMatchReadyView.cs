// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchReadyView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026B3")]
  [FlowNode.Pin(12, "BattleStart", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(102, "GoMapPlacement", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "BattleRequestExe", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(103, "GoBattleStart", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(11, "MapPlacement", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "BattleRequest", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(2, "AutoSet", FlowNode.PinTypes.Input, 2)]
  public class LeagueMatchReadyView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400B54B")]
    private const string ANIM_KEY_CLOSE = "close";
    [Token(Token = "0x400B54C")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B54D")]
    private const int PIN_IN_AUTO_SETTING = 2;
    [Token(Token = "0x400B54E")]
    private const int PIN_IN_BATTLE_REQUEST = 10;
    [Token(Token = "0x400B54F")]
    private const int PIN_IN_MAP_PLACEMENT = 11;
    [Token(Token = "0x400B550")]
    private const int PIN_IN_BATTLE = 12;
    [Token(Token = "0x400B551")]
    private const int PIN_OUT_REQUEST_EXE = 101;
    [Token(Token = "0x400B552")]
    private const int PIN_OUT_MAP_PLACEMENT = 102;
    [Token(Token = "0x400B553")]
    private const int PIN_OUT_BATTLE_START = 103;
    [Token(Token = "0x400B554")]
    private const int PIN_OUT_ERROR = 1001;
    [Token(Token = "0x400B555")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B556")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400B557")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Animator mAnimator;
    [Token(Token = "0x400B558")]
    [FieldOffset(Offset = "0x18")]
    private int mSeasonId;
    [Token(Token = "0x400B559")]
    [FieldOffset(Offset = "0x1C")]
    private LeagueMatchReadyModel mModels;
    [Token(Token = "0x400B55A")]
    [FieldOffset(Offset = "0x20")]
    private LeagueMatchBattleEditPlayerModel mPlayerModel;
    [Token(Token = "0x400B55B")]
    [FieldOffset(Offset = "0x24")]
    private LeagueMatchBattleEditEnemyModel mEnemyModel;
    [Token(Token = "0x400B55C")]
    [FieldOffset(Offset = "0x28")]
    private QuestParam mCurrentQuest;

    [Token(Token = "0x600AD06")]
    [Address(RVA = "0x70BDB0", Offset = "0x70ABB0", VA = "0x1070BDB0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600AD07")]
    [Address(RVA = "0x70BDD0", Offset = "0x70ABD0", VA = "0x1070BDD0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AD08")]
    [Address(RVA = "0x70BFB0", Offset = "0x70ADB0", VA = "0x1070BFB0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AD09")]
    [Address(RVA = "0x70CC60", Offset = "0x70BA60", VA = "0x1070CC60")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AD0A")]
    [Address(RVA = "0x70CB90", Offset = "0x70B990", VA = "0x1070CB90")]
    private void OnToggleAutoSetting()
    {
    }

    [Token(Token = "0x600AD0B")]
    [Address(RVA = "0x70CAB0", Offset = "0x70B8B0", VA = "0x1070CAB0")]
    private void OnRequestBattle()
    {
    }

    [Token(Token = "0x600AD0C")]
    [Address(RVA = "0x70C450", Offset = "0x70B250", VA = "0x1070C450")]
    private void OnMapPlacementStart()
    {
    }

    [Token(Token = "0x600AD0D")]
    [Address(RVA = "0x70C260", Offset = "0x70B060", VA = "0x1070C260")]
    private void OnBattleStart(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600AD0E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchReadyView()
    {
    }
  }
}
