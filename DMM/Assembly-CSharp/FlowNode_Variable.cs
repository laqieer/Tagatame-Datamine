// Decompiled with JetBrains decompiler
// Type: FlowNode_Variable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200022C")]
[FlowNode.Pin(11, "!= Variable", FlowNode.PinTypes.Output, 11)]
[FlowNode.Pin(10, "== Variable", FlowNode.PinTypes.Output, 10)]
[FlowNode.Pin(9, "Assigned", FlowNode.PinTypes.Output, 9)]
[FlowNode.Pin(3, "SetIfNull", FlowNode.PinTypes.Input, 3)]
[FlowNode.Pin(2, "Compare", FlowNode.PinTypes.Input, 2)]
[FlowNode.Pin(14, "> Variable", FlowNode.PinTypes.Output, 14)]
[FlowNode.NodeType("Common/Variable", 32741)]
[FlowNode.Pin(1, "Set", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(13, "<= Variable", FlowNode.PinTypes.Output, 13)]
[AddComponentMenu("")]
[FlowNode.Pin(15, ">= Variable", FlowNode.PinTypes.Output, 15)]
[FlowNode.Pin(12, "< Variable", FlowNode.PinTypes.Output, 12)]
public class FlowNode_Variable : FlowNode
{
  [Token(Token = "0x4000964")]
  [FieldOffset(Offset = "0x0")]
  private static Dictionary<string, string> mKeyValues;
  [Token(Token = "0x4000965")]
  [FieldOffset(Offset = "0x18")]
  public string Name;
  [Token(Token = "0x4000966")]
  [FieldOffset(Offset = "0x1C")]
  public string Value;

  [Token(Token = "0x6000BA5")]
  [Address(RVA = "0x1081A80", Offset = "0x1080880", VA = "0x11081A80")]
  public static void Set(string name, string value)
  {
  }

  [Token(Token = "0x6000BA6")]
  [Address(RVA = "0x1081620", Offset = "0x1080420", VA = "0x11081620")]
  public static string Get(string name) => (string) null;

  [Token(Token = "0x6000BA7")]
  [Address(RVA = "0x10816D0", Offset = "0x10804D0", VA = "0x110816D0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000BA8")]
  [Address(RVA = "0x1081550", Offset = "0x1080350", VA = "0x11081550", Slot = "6")]
  public override string[] GetInfoLines() => (string[]) null;

  [Token(Token = "0x6000BA9")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_Variable()
  {
  }

  [Token(Token = "0x6000BAA")]
  [Address(RVA = "0x1081AF0", Offset = "0x10808F0", VA = "0x11081AF0")]
  static FlowNode_Variable()
  {
  }
}
