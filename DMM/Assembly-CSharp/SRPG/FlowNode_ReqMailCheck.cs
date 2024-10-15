// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqMailCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001539")]
  [AddComponentMenu("")]
  [FlowNode.Pin(11, "false", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "true", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "ギフトがあるか", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Mail/ReqMailCheck", 32741)]
  public class FlowNode_ReqMailCheck : FlowNode_Network
  {
    [Token(Token = "0x4004D98")]
    private const int PIN_INPUT = 0;
    [Token(Token = "0x4004D99")]
    private const int PIN_TRUE = 10;
    [Token(Token = "0x4004D9A")]
    private const int PIN_FALSE = 11;

    [Token(Token = "0x60057D2")]
    [Address(RVA = "0x12D4C40", Offset = "0x12D3A40", VA = "0x112D4C40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60057D3")]
    [Address(RVA = "0x12D4CE0", Offset = "0x12D3AE0", VA = "0x112D4CE0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60057D4")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqMailCheck()
    {
    }
  }
}
