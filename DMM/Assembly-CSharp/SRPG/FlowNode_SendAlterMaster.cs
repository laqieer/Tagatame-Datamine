// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SendAlterMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001609")]
  [FlowNode.NodeType("Master/SendAlterCheck", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Failed", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_SendAlterMaster : FlowNode_Network
  {
    [Token(Token = "0x6005A9D")]
    [Address(RVA = "0x12F5B30", Offset = "0x12F4930", VA = "0x112F5B30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A9E")]
    [Address(RVA = "0x12F5DC0", Offset = "0x12F4BC0", VA = "0x112F5DC0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005A9F")]
    [Address(RVA = "0x12F5CD0", Offset = "0x12F4AD0", VA = "0x112F5CD0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005AA0")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_SendAlterMaster()
    {
    }
  }
}
