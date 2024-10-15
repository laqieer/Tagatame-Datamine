// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_RaidCheckRescueWaitSeconds
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200181B")]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "CanReload", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(102, "UseCache", FlowNode.PinTypes.Output, 3)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Raid/CheckRescueWaitSeconds", 32741)]
  public class Flownode_RaidCheckRescueWaitSeconds : FlowNode
  {
    [Token(Token = "0x6006153")]
    [Address(RVA = "0x136E000", Offset = "0x136CE00", VA = "0x1136E000", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006154")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_RaidCheckRescueWaitSeconds()
    {
    }
  }
}
