// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckJukePlayerPrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200167D")]
  [FlowNode.Pin(0, "False", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(1, "True", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "Check", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/PlayerPrefs/CheckJukePlayerPrefs", 32741)]
  public class FlowNode_CheckJukePlayerPrefs : FlowNode
  {
    [Token(Token = "0x40051D1")]
    private const int GET_FALSE = 0;
    [Token(Token = "0x40051D2")]
    private const int GET_TRUE = 1;
    [Token(Token = "0x40051D3")]
    private const int CHECK = 2;

    [Token(Token = "0x6005C52")]
    [Address(RVA = "0x1305F10", Offset = "0x1304D10", VA = "0x11305F10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C53")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckJukePlayerPrefs()
    {
    }
  }
}
