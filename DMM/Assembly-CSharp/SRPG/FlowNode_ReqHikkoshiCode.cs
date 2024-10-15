// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqHikkoshiCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001531")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Network/gauth_passcode", 32741)]
  public class FlowNode_ReqHikkoshiCode : FlowNode_Network
  {
    [Token(Token = "0x4004D88")]
    [FieldOffset(Offset = "0x20")]
    public Text HikkoshiCodeText;
    [Token(Token = "0x4004D89")]
    [FieldOffset(Offset = "0x24")]
    public Text ExpireTimeText;

    [Token(Token = "0x60057BE")]
    [Address(RVA = "0x12D3900", Offset = "0x12D2700", VA = "0x112D3900", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60057BF")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60057C0")]
    [Address(RVA = "0x12D3A50", Offset = "0x12D2850", VA = "0x112D3A50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60057C1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqHikkoshiCode()
    {
    }
  }
}
