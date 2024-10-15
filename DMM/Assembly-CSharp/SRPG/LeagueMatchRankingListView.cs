// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchRankingListView
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
  [Token(Token = "0x20026B2")]
  [FlowNode.Pin(100, "ConnectStart", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(110, "Close", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(10, "ConnectIn", FlowNode.PinTypes.Input, 10)]
  public class LeagueMatchRankingListView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400B53F")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B540")]
    private const int PIN_IN_CONNECT = 10;
    [Token(Token = "0x400B541")]
    private const int PIN_OUTPUT_CONNECT = 100;
    [Token(Token = "0x400B542")]
    private const int PIN_OUTPUT_CLOSE = 110;
    [Token(Token = "0x400B543")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x400B544")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ContentExhibit rankingContentExhibit;
    [Token(Token = "0x400B545")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList myRankingExhibit;
    [Token(Token = "0x400B546")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ImageArray rankingImageArray;
    [Token(Token = "0x400B547")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject rankingViewArea;
    [Token(Token = "0x400B548")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject rankingTotallingArea;
    [Token(Token = "0x400B549")]
    [FieldOffset(Offset = "0x20")]
    private List<LeagueMatchRankingListModel> mModels;
    [Token(Token = "0x400B54A")]
    [FieldOffset(Offset = "0x24")]
    private LeagueMatchRankingListModel mPlayerModel;

    [Token(Token = "0x600AD00")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AD01")]
    [Address(RVA = "0x70B7F0", Offset = "0x70A5F0", VA = "0x1070B7F0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600AD02")]
    [Address(RVA = "0x70BCF0", Offset = "0x70AAF0", VA = "0x1070BCF0")]
    private void Start()
    {
    }

    [Token(Token = "0x600AD03")]
    [Address(RVA = "0x70B810", Offset = "0x70A610", VA = "0x1070B810")]
    private void Initialize(SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600AD04")]
    [Address(RVA = "0x70BC20", Offset = "0x70AA20", VA = "0x1070BC20")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AD05")]
    [Address(RVA = "0x70BD40", Offset = "0x70AB40", VA = "0x1070BD40")]
    public LeagueMatchRankingListView()
    {
    }
  }
}
