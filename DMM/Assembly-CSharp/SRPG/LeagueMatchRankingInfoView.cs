// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchRankingInfoView
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
  [Token(Token = "0x20026B1")]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(110, "Close", FlowNode.PinTypes.Output, 110)]
  public class LeagueMatchRankingInfoView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400B536")]
    public const string SVB_KEY_SEASON_ID = "SVB_KEY_SEASON_ID";
    [Token(Token = "0x400B537")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B538")]
    private const int PIN_OUTPUT_CLOSE = 110;
    [Token(Token = "0x400B539")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x400B53A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform ListParent;
    [Token(Token = "0x400B53B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList ListItemTemplate;
    [Token(Token = "0x400B53C")]
    [FieldOffset(Offset = "0x14")]
    private List<LeagueMatchRankingInfoModel> mRankingModels;
    [Token(Token = "0x400B53D")]
    [FieldOffset(Offset = "0x18")]
    private List<ExhibitList> mRankingExhibitLists;
    [Token(Token = "0x400B53E")]
    [FieldOffset(Offset = "0x1C")]
    private int mSeasonId;

    [Token(Token = "0x600ACFA")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600ACFB")]
    [Address(RVA = "0x70B190", Offset = "0x709F90", VA = "0x1070B190", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600ACFC")]
    [Address(RVA = "0x70B7A0", Offset = "0x70A5A0", VA = "0x1070B7A0")]
    private void Start()
    {
    }

    [Token(Token = "0x600ACFD")]
    [Address(RVA = "0x70B1B0", Offset = "0x709FB0", VA = "0x1070B1B0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600ACFE")]
    [Address(RVA = "0x70B660", Offset = "0x70A460", VA = "0x1070B660")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600ACFF")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchRankingInfoView()
    {
    }
  }
}
