// Decompiled with JetBrains decompiler
// Type: SRPG.RuneEvoStatusWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029A5")]
  [AddComponentMenu("UI/Rune/RuneEvoStatusWindow")]
  [FlowNode.Pin(1, "Setup", FlowNode.PinTypes.Input, 1)]
  internal class RuneEvoStatusWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C99D")]
    private const int PIN_IN_SETUP = 1;
    [Token(Token = "0x400C99E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneEvoStateLottery ListView;
    [Token(Token = "0x400C99F")]
    [FieldOffset(Offset = "0x10")]
    private List<RuneLotteryEvoState> mRuneLotteryEvoState;
    [Token(Token = "0x400C9A0")]
    [FieldOffset(Offset = "0x14")]
    private List<RuneEvoStateLottery> mViews;

    [Token(Token = "0x1700198F")]
    public static BindRuneData SelectedRuneData
    {
      [Token(Token = "0x600BCF9"), Address(RVA = "0x84A070", Offset = "0x848E70", VA = "0x1084A070")] private get
      {
        return (BindRuneData) null;
      }
      [Token(Token = "0x600BCFA"), Address(RVA = "0x84A0A0", Offset = "0x848EA0", VA = "0x1084A0A0")] set
      {
      }
    }

    [Token(Token = "0x600BCFB")]
    [Address(RVA = "0x849A40", Offset = "0x848840", VA = "0x10849A40", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BCFC")]
    [Address(RVA = "0x849E80", Offset = "0x848C80", VA = "0x10849E80")]
    public void Setup()
    {
    }

    [Token(Token = "0x600BCFD")]
    [Address(RVA = "0x849C10", Offset = "0x848A10", VA = "0x10849C10")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600BCFE")]
    [Address(RVA = "0x849BD0", Offset = "0x8489D0", VA = "0x10849BD0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BCFF")]
    [Address(RVA = "0x84A000", Offset = "0x848E00", VA = "0x1084A000")]
    public RuneEvoStatusWindow()
    {
    }
  }
}
