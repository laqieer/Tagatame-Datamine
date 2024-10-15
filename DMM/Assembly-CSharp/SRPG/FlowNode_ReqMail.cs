// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqMail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001538")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Mail/ReqMail", 32741)]
  [FlowNode.Pin(0, "メール取得", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "成功", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_ReqMail : FlowNode_Network
  {
    [Token(Token = "0x4004D96")]
    private const int PIN_ID_REQUEST = 0;
    [Token(Token = "0x4004D97")]
    private const int PIN_ID_SUCCESS = 10;

    [Token(Token = "0x60057CF")]
    [Address(RVA = "0x12D51C0", Offset = "0x12D3FC0", VA = "0x112D51C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60057D0")]
    [Address(RVA = "0x12D52B0", Offset = "0x12D40B0", VA = "0x112D52B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60057D1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqMail()
    {
    }
  }
}
