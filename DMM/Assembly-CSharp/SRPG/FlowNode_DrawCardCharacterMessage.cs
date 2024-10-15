// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_DrawCardCharacterMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001346")]
  [FlowNode.NodeType("DrawCard/Character/Message", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Hidden", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(10, "Output", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_DrawCardCharacterMessage : FlowNode
  {
    [Token(Token = "0x4004761")]
    private const int PIN_IN_MESS_SHOW = 1;
    [Token(Token = "0x4004762")]
    private const int PIN_IN_MESS_HIDDEN = 2;
    [Token(Token = "0x4004763")]
    private const int PIN_OUT_END = 10;
    [Token(Token = "0x4004764")]
    [FieldOffset(Offset = "0x18")]
    [FlowNode.ShowInInfo]
    public string Message;

    [Token(Token = "0x6005111")]
    [Address(RVA = "0x124F530", Offset = "0x124E330", VA = "0x1124F530", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005112")]
    [Address(RVA = "0x124F580", Offset = "0x124E380", VA = "0x1124F580")]
    public FlowNode_DrawCardCharacterMessage()
    {
    }
  }
}
