// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchDefenseEditView
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
  [Token(Token = "0x2002694")]
  [FlowNode.Pin(11, "情報更新", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(201, "閉じる", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(102, "マップ配置保存", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(15, "防衛タブ変更", FlowNode.PinTypes.Input, 15)]
  [FlowNode.Pin(14, "閉じる実行", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(13, "UnitPlacementDecide", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(101, "マップ配置へ", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(12, "UnitPlacementOpen", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  public class LeagueMatchDefenseEditView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400B43C")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B43D")]
    private const int PIN_IN_UPDATE_DATA = 11;
    [Token(Token = "0x400B43E")]
    private const int PIN_IN_UNIT_PLACEMENT_OPEN = 12;
    [Token(Token = "0x400B43F")]
    private const int PIN_IN_UNIT_PLACEMENT_DECIDE = 13;
    [Token(Token = "0x400B440")]
    private const int PIN_IN_CLOSE = 14;
    [Token(Token = "0x400B441")]
    private const int PIN_IN_TAB_SELECT = 15;
    [Token(Token = "0x400B442")]
    private const int PIN_OUT_UNIT_PLACEMENT = 101;
    [Token(Token = "0x400B443")]
    private const int PIN_OUT_REQ_UNIT_PLACEMENT = 102;
    [Token(Token = "0x400B444")]
    private const int PIN_OUT_CLOSE = 201;
    [Token(Token = "0x400B445")]
    private const int PIN_OUT_ERROR = 1001;
    [Token(Token = "0x400B446")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mMapExhibitList;
    [Token(Token = "0x400B447")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mAttackTimeExhibitList;
    [Token(Token = "0x400B448")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentExhibit mBuffContentExhibit;
    [Token(Token = "0x400B449")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int selectTabIndex;
    [Token(Token = "0x400B44A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B44B")]
    [FieldOffset(Offset = "0x20")]
    private int mSeasonId;
    [Token(Token = "0x400B44C")]
    [FieldOffset(Offset = "0x24")]
    private UnitData[] mPartyUnits;
    [Token(Token = "0x400B44D")]
    [FieldOffset(Offset = "0x28")]
    private LeagueMatchMapModel mMapModel;
    [Token(Token = "0x400B44E")]
    [FieldOffset(Offset = "0x2C")]
    private List<LeagueMatchBuffModel> mBuffModels;
    [Token(Token = "0x400B44F")]
    [FieldOffset(Offset = "0x30")]
    private LeagueMatchAttackTimeModel mAttackTimeModel;
    [Token(Token = "0x400B450")]
    [FieldOffset(Offset = "0x34")]
    private JSON_LeagueMatchDefenseParty mParty;

    [Token(Token = "0x600AC3D")]
    [Address(RVA = "0x6F7130", Offset = "0x6F5F30", VA = "0x106F7130", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AC3E")]
    [Address(RVA = "0x6F7110", Offset = "0x6F5F10", VA = "0x106F7110", Slot = "5")]
    public void Activated(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600AC3F")]
    [Address(RVA = "0x6F74B0", Offset = "0x6F62B0", VA = "0x106F74B0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AC40")]
    [Address(RVA = "0x6F8400", Offset = "0x6F7200", VA = "0x106F8400")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AC41")]
    [Address(RVA = "0x6F8080", Offset = "0x6F6E80", VA = "0x106F8080")]
    private void RefreshParty()
    {
    }

    [Token(Token = "0x600AC42")]
    [Address(RVA = "0x6F7F50", Offset = "0x6F6D50", VA = "0x106F7F50")]
    private void RefreshMap()
    {
    }

    [Token(Token = "0x600AC43")]
    [Address(RVA = "0x6F7C40", Offset = "0x6F6A40", VA = "0x106F7C40")]
    private void RefreshBuff()
    {
    }

    [Token(Token = "0x600AC44")]
    [Address(RVA = "0x6F82A0", Offset = "0x6F70A0", VA = "0x106F82A0")]
    private void RefreshTabTime()
    {
    }

    [Token(Token = "0x600AC45")]
    [Address(RVA = "0x6F7960", Offset = "0x6F6760", VA = "0x106F7960")]
    private void OpenUnitMapPlacement()
    {
    }

    [Token(Token = "0x600AC46")]
    [Address(RVA = "0x6F85F0", Offset = "0x6F73F0", VA = "0x106F85F0")]
    private void UnitMapPlacemenDatatSet(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600AC47")]
    [Address(RVA = "0x6F8550", Offset = "0x6F7350", VA = "0x106F8550")]
    private void SelectTab()
    {
    }

    [Token(Token = "0x600AC48")]
    [Address(RVA = "0x6F7270", Offset = "0x6F6070", VA = "0x106F7270")]
    private void ChangePartieData(int tabIndex)
    {
    }

    [Token(Token = "0x600AC49")]
    [Address(RVA = "0x6F7830", Offset = "0x6F6630", VA = "0x106F7830")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600AC4A")]
    [Address(RVA = "0x6F8870", Offset = "0x6F7670", VA = "0x106F8870")]
    public LeagueMatchDefenseEditView()
    {
    }

    [Token(Token = "0x2002695")]
    private enum LeagueMatchDefenceTabIndex
    {
      [Token(Token = "0x400B452")] Next = 1,
      [Token(Token = "0x400B453")] AfterNext = 2,
    }
  }
}
