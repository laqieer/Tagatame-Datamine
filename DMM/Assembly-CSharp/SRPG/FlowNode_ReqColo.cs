// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqColo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014C8")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Network/btl_colo", 32741)]
  public class FlowNode_ReqColo : FlowNode_Network
  {
    [Token(Token = "0x6005694")]
    [Address(RVA = "0x12C1540", Offset = "0x12C0340", VA = "0x112C1540", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005695")]
    [Address(RVA = "0x107A1E0", Offset = "0x1078FE0", VA = "0x1107A1E0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005696")]
    [Address(RVA = "0x12C1640", Offset = "0x12C0440", VA = "0x112C1640", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005697")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqColo()
    {
    }
  }
}
