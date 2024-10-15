// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_BattleSignal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023D0")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Battle/Signal", 4513092)]
  [FlowNode.Pin(1, "Stop", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "Resume", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "Out", FlowNode.PinTypes.Output, 1000)]
  public class FlowNode_BattleSignal : FlowNode
  {
    [Token(Token = "0x6009B2A")]
    [Address(RVA = "0x5ED3B0", Offset = "0x5EC1B0", VA = "0x105ED3B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6009B2B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_BattleSignal()
    {
    }
  }
}
