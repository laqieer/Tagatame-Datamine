﻿// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_BattleEndState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023CB")]
  [FlowNode.NodeType("Battle/EndState", 32741)]
  [FlowNode.Pin(1, "Cancel", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Accept", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_BattleEndState : FlowNode
  {
    [Token(Token = "0x6009B1F")]
    [Address(RVA = "0x5ECF20", Offset = "0x5EBD20", VA = "0x105ECF20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6009B20")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_BattleEndState()
    {
    }
  }
}