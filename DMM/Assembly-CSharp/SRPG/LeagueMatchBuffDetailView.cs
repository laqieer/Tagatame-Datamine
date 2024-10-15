// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchBuffDetailView
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
  [Token(Token = "0x200268C")]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  public class LeagueMatchBuffDetailView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B417")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B418")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x400B419")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mBuffExhibit;
    [Token(Token = "0x400B41A")]
    [FieldOffset(Offset = "0x10")]
    private LeagueMatchBuffModel mModel;

    [Token(Token = "0x600AC1C")]
    [Address(RVA = "0x6F4DD0", Offset = "0x6F3BD0", VA = "0x106F4DD0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AC1D")]
    [Address(RVA = "0x6F4DF0", Offset = "0x6F3BF0", VA = "0x106F4DF0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AC1E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchBuffDetailView()
    {
    }
  }
}
