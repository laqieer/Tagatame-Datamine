// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_BattleFocusUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023CC")]
  [FlowNode.NodeType("Battle/FocusUnit", 32741)]
  [FlowNode.Pin(0, "フォーカス", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  public class FlowNode_BattleFocusUnit : FlowNode
  {
    [Token(Token = "0x6009B21")]
    [Address(RVA = "0x5ECFC0", Offset = "0x5EBDC0", VA = "0x105ECFC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6009B22")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_BattleFocusUnit()
    {
    }
  }
}
