// Decompiled with JetBrains decompiler
// Type: FlowNode_AchievementStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001C2")]
[FlowNode.NodeType("Achievement/Status", 58751)]
[FlowNode.Pin(1, "Turn Auth True", FlowNode.PinTypes.Output, 0)]
[FlowNode.Pin(2, "Turn Auth False", FlowNode.PinTypes.Output, 1)]
[AddComponentMenu("")]
public class FlowNode_AchievementStatus : FlowNodePersistent
{
  [Token(Token = "0x400081A")]
  [FieldOffset(Offset = "0x18")]
  private bool mIsAuth;

  [Token(Token = "0x6000A64")]
  [Address(RVA = "0xF47500", Offset = "0xF46300", VA = "0x10F47500")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A65")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_AchievementStatus()
  {
  }
}
