// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchMapListView
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
  [Token(Token = "0x20026A0")]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(5, "PagePrev", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(110, "Close", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(101, "MapSelect", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(2, "Refresh", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(6, "PageNext", FlowNode.PinTypes.Input, 6)]
  public class LeagueMatchMapListView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B49B")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B49C")]
    private const int PIN_IN_REFRESH = 2;
    [Token(Token = "0x400B49D")]
    private const int PIN_IN_PREV_PAGE = 5;
    [Token(Token = "0x400B49E")]
    private const int PIN_IN_NEXT_PAGE = 6;
    [Token(Token = "0x400B49F")]
    private const int PIN_OUTPUT_MAP_SELECT = 101;
    [Token(Token = "0x400B4A0")]
    private const int PIN_OUTPUT_CLOSE = 110;
    [Token(Token = "0x400B4A1")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x400B4A2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400B4A3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform MapParent;
    [Token(Token = "0x400B4A4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ExhibitList MapTemplate;
    [Token(Token = "0x400B4A5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B4A6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [HeaderBar("▼1ページに表示する最大数")]
    private int mPageContentMax;
    [Token(Token = "0x400B4A7")]
    [FieldOffset(Offset = "0x20")]
    private LeagueMatchMapListModel mMapListModel;
    [Token(Token = "0x400B4A8")]
    [FieldOffset(Offset = "0x24")]
    private List<LeagueMatchMapModel> mMapModels;
    [Token(Token = "0x400B4A9")]
    [FieldOffset(Offset = "0x28")]
    private List<ExhibitList> mMapExhibitLists;
    [Token(Token = "0x400B4AA")]
    [FieldOffset(Offset = "0x2C")]
    private string mSelectQuestIname;
    [Token(Token = "0x400B4AB")]
    [FieldOffset(Offset = "0x30")]
    private List<QuestParam> mQuestList;
    [Token(Token = "0x400B4AC")]
    [FieldOffset(Offset = "0x34")]
    private int mSeasonId;
    [Token(Token = "0x400B4AD")]
    [FieldOffset(Offset = "0x38")]
    private bool mIsShamBattle;
    [Token(Token = "0x400B4AE")]
    [FieldOffset(Offset = "0x3C")]
    private int mNowPageCount;
    [Token(Token = "0x400B4AF")]
    [FieldOffset(Offset = "0x40")]
    private int mMaxPageCount;

    [Token(Token = "0x600AC8D")]
    [Address(RVA = "0x6FCED0", Offset = "0x6FBCD0", VA = "0x106FCED0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AC8E")]
    [Address(RVA = "0x6FD040", Offset = "0x6FBE40", VA = "0x106FD040")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AC8F")]
    [Address(RVA = "0x6FD420", Offset = "0x6FC220", VA = "0x106FD420")]
    private void RefreshData()
    {
    }

    [Token(Token = "0x600AC90")]
    [Address(RVA = "0x6FD530", Offset = "0x6FC330", VA = "0x106FD530")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AC91")]
    [Address(RVA = "0x6FDA20", Offset = "0x6FC820", VA = "0x106FDA20")]
    private void UpdatePage(int num)
    {
    }

    [Token(Token = "0x600AC92")]
    [Address(RVA = "0x6FD990", Offset = "0x6FC790", VA = "0x106FD990")]
    public void SelectQuest(string quest_iname)
    {
    }

    [Token(Token = "0x600AC93")]
    [Address(RVA = "0x6FDA60", Offset = "0x6FC860", VA = "0x106FDA60")]
    public LeagueMatchMapListView()
    {
    }
  }
}
