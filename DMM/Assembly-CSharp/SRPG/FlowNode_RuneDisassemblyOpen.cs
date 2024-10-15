// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RuneDisassemblyOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200185B")]
  [FlowNode.NodeType("Rune/RuneDisassemblyOpen", 32741)]
  [FlowNode.Pin(10, "ルーン分解ウィンドウを開く", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "output", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_RuneDisassemblyOpen : FlowNode
  {
    [Token(Token = "0x400575F")]
    private const int INPUT_RUNE_DISASSEMBLY_WINDOW_OPEN = 10;
    [Token(Token = "0x4005760")]
    private const int PIN_OUTPUT = 100;

    [Token(Token = "0x6006249")]
    [Address(RVA = "0x315620", Offset = "0x314420", VA = "0x10315620", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600624A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RuneDisassemblyOpen()
    {
    }
  }
}
