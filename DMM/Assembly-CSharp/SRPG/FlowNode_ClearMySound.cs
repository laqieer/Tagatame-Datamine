// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ClearMySound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200139A")]
  [FlowNode.Pin(1000, "End", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Sound/ClearMySound", 65535)]
  [AddComponentMenu("")]
  public class FlowNode_ClearMySound : FlowNode
  {
    [Token(Token = "0x4004867")]
    private const int PIN_INPUT_START = 0;
    [Token(Token = "0x4004868")]
    private const int PIN_OUTPUT_END = 1000;

    [Token(Token = "0x6005221")]
    [Address(RVA = "0x126E9B0", Offset = "0x126D7B0", VA = "0x1126E9B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005222")]
    [Address(RVA = "0x126E940", Offset = "0x126D740", VA = "0x1126E940")]
    private IEnumerator Clear() => (IEnumerator) null;

    [Token(Token = "0x6005223")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ClearMySound()
    {
    }
  }
}
