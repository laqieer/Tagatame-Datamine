// Decompiled with JetBrains decompiler
// Type: FlowNode_IsFgGBuy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001C0")]
[AddComponentMenu("")]
[FlowNode.Pin(11, "NG", FlowNode.PinTypes.Output, 11)]
[FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(10, "OK", FlowNode.PinTypes.Output, 10)]
[FlowNode.NodeType("BuyCoin/IsFgGBuy", 32741)]
public class FlowNode_IsFgGBuy : FlowNode
{
  [Token(Token = "0x4000817")]
  private const int PIN_INPUT = 0;
  [Token(Token = "0x4000818")]
  private const int PIN_OUTPUT_OK = 10;
  [Token(Token = "0x4000819")]
  private const int PIN_OUTPUT_NG = 11;

  [Token(Token = "0x6000A5F")]
  [Address(RVA = "0xF4EC60", Offset = "0xF4DA60", VA = "0x10F4EC60", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A60")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0")]
  public static bool IsFgGBuy() => new bool();

  [Token(Token = "0x6000A61")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_IsFgGBuy()
  {
  }
}
