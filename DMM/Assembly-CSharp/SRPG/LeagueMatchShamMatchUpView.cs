// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchShamMatchUpView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026B4")]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(112, "BattleClose", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(111, "ReadyClose", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(2, "AutoSet", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(101, "OpenMapPlacement", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(11, "MapPlacement", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(12, "BattleStart", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(102, "GoBattleStart", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(21, "GoShamDefense", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(22, "GoShamBattle", FlowNode.PinTypes.Input, 22)]
  [FlowNode.Pin(31, "BackButton", FlowNode.PinTypes.Input, 31)]
  public class LeagueMatchShamMatchUpView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400B55D")]
    private const string ANIM_KEY_RESULT = "result";
    [Token(Token = "0x400B55E")]
    private const string ANIM_KEY_CLOSE = "close";
    [Token(Token = "0x400B55F")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B560")]
    private const int PIN_IN_AUTO_SETTING = 2;
    [Token(Token = "0x400B561")]
    private const int PIN_IN_MAP_PLACEMENT = 11;
    [Token(Token = "0x400B562")]
    private const int PIN_IN_BATTLE = 12;
    [Token(Token = "0x400B563")]
    private const int PIN_IN_GO_SHAM_DEFENSE = 21;
    [Token(Token = "0x400B564")]
    private const int PIN_IN_GO_SHAM_BATTLE = 22;
    [Token(Token = "0x400B565")]
    private const int PIN_IN_BACK_BTN = 31;
    [Token(Token = "0x400B566")]
    private const int PIN_OUT_OPEN_MAP_PLACEMENT = 101;
    [Token(Token = "0x400B567")]
    private const int PIN_OUT_BATTLE_START = 102;
    [Token(Token = "0x400B568")]
    private const int PIN_OUT_READY_CLOSE = 111;
    [Token(Token = "0x400B569")]
    private const int PIN_OUT_BATTLE_CLOSE = 112;
    [Token(Token = "0x400B56A")]
    private const int PIN_OUT_ERROR = 1001;
    [Token(Token = "0x400B56B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B56C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400B56D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Animator mAnimator;
    [Token(Token = "0x400B56E")]
    [FieldOffset(Offset = "0x18")]
    private LeagueMatchShamMatchUpModel mModel;
    [Token(Token = "0x400B56F")]
    [FieldOffset(Offset = "0x1C")]
    private string mMapIname;
    [Token(Token = "0x400B570")]
    [FieldOffset(Offset = "0x20")]
    private List<string> mBuffs;
    [Token(Token = "0x400B571")]
    [FieldOffset(Offset = "0x24")]
    private JSON_LeagueMatchSet[] mEnemyPlacement;
    [Token(Token = "0x400B572")]
    [FieldOffset(Offset = "0x0")]
    private static bool mIsShamResult;
    [Token(Token = "0x400B573")]
    [FieldOffset(Offset = "0x1")]
    private static bool mIsBattleWin;
    [Token(Token = "0x400B574")]
    [FieldOffset(Offset = "0x4")]
    private static List<Unit> mPlayerUnits;
    [Token(Token = "0x400B575")]
    [FieldOffset(Offset = "0x8")]
    private static List<Unit> mEnemyUnits;

    [Token(Token = "0x600AD10")]
    [Address(RVA = "0x70F450", Offset = "0x70E250", VA = "0x1070F450")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x600AD11")]
    [Address(RVA = "0x70FAF0", Offset = "0x70E8F0", VA = "0x1070FAF0")]
    public static void Setup(List<Unit> player_units, List<Unit> enemy_units, bool is_win)
    {
    }

    [Token(Token = "0x600AD12")]
    [Address(RVA = "0x70DB60", Offset = "0x70C960", VA = "0x1070DB60", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600AD13")]
    [Address(RVA = "0x70D8B0", Offset = "0x70C6B0", VA = "0x1070D8B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AD14")]
    [Address(RVA = "0x70E770", Offset = "0x70D570", VA = "0x1070E770")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AD15")]
    [Address(RVA = "0x70E160", Offset = "0x70CF60", VA = "0x1070E160")]
    private void CreateUnit()
    {
    }

    [Token(Token = "0x600AD16")]
    [Address(RVA = "0x70DB80", Offset = "0x70C980", VA = "0x1070DB80")]
    private void CreateUnitHistory()
    {
    }

    [Token(Token = "0x600AD17")]
    [Address(RVA = "0x70FA70", Offset = "0x70E870", VA = "0x1070FA70")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600AD18")]
    [Address(RVA = "0x70F4D0", Offset = "0x70E2D0", VA = "0x1070F4D0")]
    private void OnToggleAutoSetting()
    {
    }

    [Token(Token = "0x600AD19")]
    [Address(RVA = "0x70F2B0", Offset = "0x70E0B0", VA = "0x1070F2B0")]
    private void OnClickClose()
    {
    }

    [Token(Token = "0x600AD1A")]
    [Address(RVA = "0x70F3E0", Offset = "0x70E1E0", VA = "0x1070F3E0")]
    private void OnClickGoShamDefense()
    {
    }

    [Token(Token = "0x600AD1B")]
    [Address(RVA = "0x70F360", Offset = "0x70E160", VA = "0x1070F360")]
    private void OnClickGoShamBattle()
    {
    }

    [Token(Token = "0x600AD1C")]
    [Address(RVA = "0x70F5A0", Offset = "0x70E3A0", VA = "0x1070F5A0")]
    private void OpenOffenseMapPlacement()
    {
    }

    [Token(Token = "0x600AD1D")]
    [Address(RVA = "0x70E9F0", Offset = "0x70D7F0", VA = "0x1070E9F0")]
    private void OffenseUnitMapPlacementDataSet(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600AD1E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchShamMatchUpView()
    {
    }
  }
}
