// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SelectServer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001603")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "開発用", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "安定版", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Network/SelectServer", 32741)]
  [FlowNode.Pin(2, "Output", FlowNode.PinTypes.Output, 2)]
  public class FlowNode_SelectServer : FlowNode
  {
    [Token(Token = "0x6005A8A")]
    [Address(RVA = "0x12F4150", Offset = "0x12F2F50", VA = "0x112F4150", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A8B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SelectServer()
    {
    }
  }
}
