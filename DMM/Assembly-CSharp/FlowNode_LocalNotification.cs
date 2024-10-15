// Decompiled with JetBrains decompiler
// Type: FlowNode_LocalNotification
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001EA")]
[FlowNode.NodeType("System/Notify/LocalNotification", 65535)]
[FlowNode.Pin(0, "SetUp", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(1, "SetUpEnd", FlowNode.PinTypes.Output, 1)]
[AddComponentMenu("")]
public class FlowNode_LocalNotification : FlowNode
{
  [Token(Token = "0x400088C")]
  [FieldOffset(Offset = "0x18")]
  public string path;

  [Token(Token = "0x6000AEF")]
  [Address(RVA = "0xF4EEE0", Offset = "0xF4DCE0", VA = "0x10F4EEE0")]
  private void Init()
  {
  }

  [Token(Token = "0x6000AF0")]
  [Address(RVA = "0xF4EF30", Offset = "0xF4DD30", VA = "0x10F4EF30", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AF1")]
  [Address(RVA = "0xF4EF90", Offset = "0xF4DD90", VA = "0x10F4EF90")]
  public FlowNode_LocalNotification()
  {
  }
}
