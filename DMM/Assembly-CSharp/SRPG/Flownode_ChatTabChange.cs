// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_ChatTabChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001378")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "ChangeTab", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "End", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("Chat/ChatTabChange", 32741)]
  public class Flownode_ChatTabChange : FlowNode
  {
    [Token(Token = "0x40047DE")]
    private const int PIN_INPUT_CHANGE = 1;
    [Token(Token = "0x40047DF")]
    private const int PIN_OUTPUT_END = 100;
    [Token(Token = "0x40047E0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ChatWindow.eChatType mChatType;

    [Token(Token = "0x60051B3")]
    [Address(RVA = "0x1276FB0", Offset = "0x1275DB0", VA = "0x11276FB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051B4")]
    [Address(RVA = "0x1080EF0", Offset = "0x107FCF0", VA = "0x11080EF0")]
    public Flownode_ChatTabChange()
    {
    }
  }
}
