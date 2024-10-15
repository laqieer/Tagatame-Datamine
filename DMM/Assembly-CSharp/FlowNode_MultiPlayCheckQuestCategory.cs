// Decompiled with JetBrains decompiler
// Type: FlowNode_MultiPlayCheckQuestCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001EC")]
[AddComponentMenu("")]
[FlowNode.Pin(3, "Both", FlowNode.PinTypes.Output, 0)]
[FlowNode.Pin(2, "EventOnly", FlowNode.PinTypes.Output, 0)]
[FlowNode.Pin(1, "NormalOnly", FlowNode.PinTypes.Output, 0)]
[FlowNode.Pin(0, "None", FlowNode.PinTypes.Output, 0)]
[FlowNode.Pin(100, "TestExist", FlowNode.PinTypes.Input, 0)]
[FlowNode.NodeType("Multi/MultiPlayCheckQuestCategory", 32741)]
public class FlowNode_MultiPlayCheckQuestCategory : FlowNode
{
  [Token(Token = "0x6000AF4")]
  [Address(RVA = "0xF4F140", Offset = "0xF4DF40", VA = "0x10F4F140", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AF5")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_MultiPlayCheckQuestCategory()
  {
  }
}
