// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqApproveFriend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001483")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.NodeType("System/Friend/ApproveFriend", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  public class FlowNode_ReqApproveFriend : FlowNode_Network
  {
    [Token(Token = "0x4004BC4")]
    [FieldOffset(Offset = "0x20")]
    private string req_fuid;

    [Token(Token = "0x60055B1")]
    [Address(RVA = "0x12B5AF0", Offset = "0x12B48F0", VA = "0x112B5AF0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60055B2")]
    [Address(RVA = "0x12B5FE0", Offset = "0x12B4DE0", VA = "0x112B5FE0")]
    private void Success()
    {
    }

    [Token(Token = "0x60055B3")]
    [Address(RVA = "0x12B5CF0", Offset = "0x12B4AF0", VA = "0x112B5CF0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055B4")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqApproveFriend()
    {
    }
  }
}
