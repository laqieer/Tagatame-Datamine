// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SellPiece
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001608")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/Shop/SellPiece", 32741)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_SellPiece : FlowNode_Network
  {
    [Token(Token = "0x6005A99")]
    [Address(RVA = "0x12F54A0", Offset = "0x12F42A0", VA = "0x112F54A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A9A")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005A9B")]
    [Address(RVA = "0x12F5840", Offset = "0x12F4640", VA = "0x112F5840", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005A9C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_SellPiece()
    {
    }
  }
}
