// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchMissionView
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
  [Token(Token = "0x20026A2")]
  [FlowNode.Pin(2, "Refresh", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(5, "SelectReceive", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(6, "AllReceive", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(101, "ReqestRewardReceive", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  public class LeagueMatchMissionView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400B4B2")]
    private const string SVB_KEY_ITEM_TOGGLE = "SVB_KEY_ITEM_TOGGLE";
    [Token(Token = "0x400B4B3")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B4B4")]
    private const int PIN_IN_REFRESH = 2;
    [Token(Token = "0x400B4B5")]
    private const int PIN_IN_SELECT_RECEIVE = 5;
    [Token(Token = "0x400B4B6")]
    private const int PIN_IN_ALL_RECEIVE = 6;
    [Token(Token = "0x400B4B7")]
    private const int PIN_OUT_REQ_RECEIVE = 101;
    [Token(Token = "0x400B4B8")]
    private const int PIN_OUT_ERROR = 1001;
    [Token(Token = "0x400B4B9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B4BA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentExhibit mContentExhibit;
    [Token(Token = "0x400B4BB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SRPG_Button mAllReceiveBtn;
    [Token(Token = "0x400B4BC")]
    [FieldOffset(Offset = "0x18")]
    private List<LeagueMatchMissionParam> mLeagueMatchMissionParams;
    [Token(Token = "0x400B4BD")]
    [FieldOffset(Offset = "0x1C")]
    private List<LeagueMatchMissionModel> mModels;
    [Token(Token = "0x400B4BE")]
    [FieldOffset(Offset = "0x20")]
    private List<string> mClearMissionInames;

    [Token(Token = "0x600AC96")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600AC97")]
    [Address(RVA = "0x6FDAB0", Offset = "0x6FC8B0", VA = "0x106FDAB0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AC98")]
    [Address(RVA = "0x6FDB30", Offset = "0x6FC930", VA = "0x106FDB30")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AC99")]
    [Address(RVA = "0x6FDF40", Offset = "0x6FCD40", VA = "0x106FDF40")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AC9A")]
    [Address(RVA = "0x6FDD30", Offset = "0x6FCB30", VA = "0x106FDD30")]
    private void OnClickReceive(bool is_all = false)
    {
    }

    [Token(Token = "0x600AC9B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchMissionView()
    {
    }
  }
}
