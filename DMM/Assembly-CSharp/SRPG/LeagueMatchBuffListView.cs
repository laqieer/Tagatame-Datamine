// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchBuffListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200268D")]
  [FlowNode.Pin(101, "ReqBuffSet", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "ReqBuffSetShamBattle", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "Close", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(2, "BuffSelect", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(5, "DecideBuffSet", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(6, "SelectClear", FlowNode.PinTypes.Input, 6)]
  public class LeagueMatchBuffListView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B41B")]
    private const string SVB_KEY_ITEM_TOGGLE = "SVB_KEY_ITEM_TOGGLE";
    [Token(Token = "0x400B41C")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B41D")]
    private const int PIN_IN_BUFF_SELECT = 2;
    [Token(Token = "0x400B41E")]
    private const int PIN_IN_DECIDE_BUFF = 5;
    [Token(Token = "0x400B41F")]
    private const int PIN_IN_SELECT_CLEAR = 6;
    [Token(Token = "0x400B420")]
    private const int PIN_OUT_REQ_BUFF_SET = 101;
    [Token(Token = "0x400B421")]
    private const int PIN_OUT_REQ_BUFF_SET_SHAM = 102;
    [Token(Token = "0x400B422")]
    private const int PIN_OUT_CLOSE = 103;
    [Token(Token = "0x400B423")]
    private const int PIN_OUT_ERROR = 1001;
    [Token(Token = "0x400B424")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B425")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentExhibit mContentExhibit;
    [Token(Token = "0x400B426")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mSelectNumText;
    [Token(Token = "0x400B427")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mSelectNumMax;
    [Token(Token = "0x400B428")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Color mSelectNumDefaultColor;
    [Token(Token = "0x400B429")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Color mSelectNumMaxColor;
    [Token(Token = "0x400B42A")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mTitleTextMainBattlle;
    [Token(Token = "0x400B42B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mTitleTextShamBattlle;
    [Token(Token = "0x400B42C")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private SRPG_Button mAllClearBtn;
    [Token(Token = "0x400B42D")]
    [FieldOffset(Offset = "0x48")]
    private bool mIsShamBattle;
    [Token(Token = "0x400B42E")]
    [FieldOffset(Offset = "0x4C")]
    private LeagueMatchSeasonParam mLeagueMatchSeasonParam;
    [Token(Token = "0x400B42F")]
    [FieldOffset(Offset = "0x50")]
    private LeagueMatchBuffParam mLeagueMatchBuffParam;
    [Token(Token = "0x400B430")]
    [FieldOffset(Offset = "0x54")]
    private List<LeagueMatchBuffModel> mModels;
    [Token(Token = "0x400B431")]
    [FieldOffset(Offset = "0x58")]
    private List<JSON_LeagueMatchBuffs> mCurrentBuffDatas;
    [Token(Token = "0x400B432")]
    [FieldOffset(Offset = "0x5C")]
    private List<string> mSelectBuffInames;

    [Token(Token = "0x600AC1F")]
    [Address(RVA = "0x6F5100", Offset = "0x6F3F00", VA = "0x106F5100", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AC20")]
    [Address(RVA = "0x6F5B80", Offset = "0x6F4980", VA = "0x106F5B80")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AC21")]
    [Address(RVA = "0x6F5530", Offset = "0x6F4330", VA = "0x106F5530")]
    private void InitializeData()
    {
    }

    [Token(Token = "0x600AC22")]
    [Address(RVA = "0x6F6820", Offset = "0x6F5620", VA = "0x106F6820")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AC23")]
    [Address(RVA = "0x6F64C0", Offset = "0x6F52C0", VA = "0x106F64C0")]
    public void OnSelectBuff()
    {
    }

    [Token(Token = "0x600AC24")]
    [Address(RVA = "0x6F6E90", Offset = "0x6F5C90", VA = "0x106F6E90")]
    private void UpdateSelectData(string buff_iname, bool is_add)
    {
    }

    [Token(Token = "0x600AC25")]
    [Address(RVA = "0x6F5E40", Offset = "0x6F4C40", VA = "0x106F5E40")]
    private void OnCheckDecideBuff()
    {
    }

    [Token(Token = "0x600AC26")]
    [Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x106F5FA0")]
    private void OnDecideBuff()
    {
    }

    [Token(Token = "0x600AC27")]
    [Address(RVA = "0x6F53F0", Offset = "0x6F41F0", VA = "0x106F53F0")]
    private void ForceDefaultBuffSet()
    {
    }

    [Token(Token = "0x600AC28")]
    [Address(RVA = "0x6F6AD0", Offset = "0x6F58D0", VA = "0x106F6AD0")]
    private void SelectBuffAllClear()
    {
    }

    [Token(Token = "0x600AC29")]
    [Address(RVA = "0x6F7060", Offset = "0x6F5E60", VA = "0x106F7060")]
    public LeagueMatchBuffListView()
    {
    }
  }
}
