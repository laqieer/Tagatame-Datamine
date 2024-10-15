// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqColoEnemy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014C9")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.NodeType("Network/btl_colo_enemy", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  public class FlowNode_ReqColoEnemy : FlowNode_Network
  {
    [Token(Token = "0x6005698")]
    [Address(RVA = "0x12C0EA0", Offset = "0x12BFCA0", VA = "0x112C0EA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005699")]
    [Address(RVA = "0x12C0F40", Offset = "0x12BFD40", VA = "0x112C0F40", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600569A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqColoEnemy()
    {
    }
  }
}
