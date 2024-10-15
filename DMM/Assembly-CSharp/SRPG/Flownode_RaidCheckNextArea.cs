// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_RaidCheckNextArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001818")]
  [AddComponentMenu("")]
  [FlowNode.Pin(900, "Error", FlowNode.PinTypes.Output, 9)]
  [FlowNode.NodeType("Raid/CheckNextArea", 32741)]
  [FlowNode.Pin(101, "Has Next Area", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(102, "Last Area", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  public class Flownode_RaidCheckNextArea : FlowNode
  {
    [Token(Token = "0x600614D")]
    [Address(RVA = "0x136DB80", Offset = "0x136C980", VA = "0x1136DB80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600614E")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_RaidCheckNextArea()
    {
    }
  }
}
