// Decompiled with JetBrains decompiler
// Type: FlowNode_ExecuteScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001D4")]
[FlowNode.NodeType("Common/Script", 32741)]
[FlowNode.Pin(10, "Input", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
[AddComponentMenu("")]
public class FlowNode_ExecuteScript : FlowNode
{
  [Token(Token = "0x400084B")]
  [FieldOffset(Offset = "0x18")]
  public string ScriptName;

  [Token(Token = "0x6000A92")]
  [Address(RVA = "0xF497E0", Offset = "0xF485E0", VA = "0x10F497E0", Slot = "10")]
  public override string GetCaption() => (string) null;

  [Token(Token = "0x6000A93")]
  [Address(RVA = "0xF49830", Offset = "0xF48630", VA = "0x10F49830", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A94")]
  [Address(RVA = "0xF49850", Offset = "0xF48650", VA = "0x10F49850")]
  public FlowNode_ExecuteScript()
  {
  }
}
