// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqChatUserDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014BC")]
  [FlowNode.NodeType("System/ReqChat/ReqChatUserDetail", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ReqChatUserDetail : FlowNode_Network
  {
    [Token(Token = "0x4004C1C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ChatPlayerWindow window;
    [Token(Token = "0x4004C1D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private FriendDetailWindow detail;

    [Token(Token = "0x6005679")]
    [Address(RVA = "0x12BF240", Offset = "0x12BE040", VA = "0x112BF240", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600567A")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x600567B")]
    [Address(RVA = "0x12BF320", Offset = "0x12BE120", VA = "0x112BF320", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600567C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqChatUserDetail()
    {
    }
  }
}
