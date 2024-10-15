// Decompiled with JetBrains decompiler
// Type: FlowNode_LocalizedText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001E9")]
[FlowNode.NodeType("Common/LocalizedText", 32741)]
[FlowNode.Pin(0, "Load", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(1, "Reload", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(10, "Unload", FlowNode.PinTypes.Input, 2)]
[FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 10)]
[AddComponentMenu("")]
public class FlowNode_LocalizedText : FlowNode
{
  [Token(Token = "0x400088B")]
  [FieldOffset(Offset = "0x18")]
  public string tableID;

  [Token(Token = "0x6000AED")]
  [Address(RVA = "0xF4F020", Offset = "0xF4DE20", VA = "0x10F4F020", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AEE")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_LocalizedText()
  {
  }
}
