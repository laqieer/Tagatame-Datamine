// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchEnemyDetailView
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
  [Token(Token = "0x2002696")]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  public class LeagueMatchEnemyDetailView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B454")]
    public const string IS_DISABLE_HIDE = "IS_DISABLE_HIDE";
    [Token(Token = "0x400B455")]
    public const string IS_ENEMY_DETAIL = "IS_ENEMY_DETAIL";
    [Token(Token = "0x400B456")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B457")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x400B458")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mMapExhibitList;
    [Token(Token = "0x400B459")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentExhibit mBuffContentExhibit;
    [Token(Token = "0x400B45A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B45B")]
    [FieldOffset(Offset = "0x18")]
    private LeagueMatchMapModel mMapModel;
    [Token(Token = "0x400B45C")]
    [FieldOffset(Offset = "0x1C")]
    private List<LeagueMatchBuffModel> mBuffModels;

    [Token(Token = "0x600AC4B")]
    [Address(RVA = "0x6F8890", Offset = "0x6F7690", VA = "0x106F8890", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AC4C")]
    [Address(RVA = "0x6F88B0", Offset = "0x6F76B0", VA = "0x106F88B0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AC4D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchEnemyDetailView()
    {
    }
  }
}
