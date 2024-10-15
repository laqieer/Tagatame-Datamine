// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqChatBlackList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014B6")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "Maintenance", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Request/ReqBlackList(ブロックリスト取得)", 32741)]
  public class FlowNode_ReqChatBlackList : FlowNode_Network
  {
    [Token(Token = "0x4004C0D")]
    [FieldOffset(Offset = "0x20")]
    public int GetLimit;
    [Token(Token = "0x4004C0E")]
    [FieldOffset(Offset = "0x24")]
    public bool IsGetOnly;

    [Token(Token = "0x6005659")]
    [Address(RVA = "0x12BDF20", Offset = "0x12BCD20", VA = "0x112BDF20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600565A")]
    [Address(RVA = "0x12BE470", Offset = "0x12BD270", VA = "0x112BE470")]
    private void Success()
    {
    }

    [Token(Token = "0x600565B")]
    [Address(RVA = "0x12BDE00", Offset = "0x12BCC00", VA = "0x112BDE00")]
    private void ChatMaintenance()
    {
    }

    [Token(Token = "0x600565C")]
    [Address(RVA = "0x12BE070", Offset = "0x12BCE70", VA = "0x112BE070", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600565D")]
    [Address(RVA = "0x12BE4E0", Offset = "0x12BD2E0", VA = "0x112BE4E0")]
    public FlowNode_ReqChatBlackList()
    {
    }
  }
}
