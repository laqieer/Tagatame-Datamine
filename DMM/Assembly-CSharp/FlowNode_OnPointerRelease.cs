// Decompiled with JetBrains decompiler
// Type: FlowNode_OnPointerRelease
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001F7")]
[FlowNode.NodeType("Event/OnPointerRelease", 58751)]
[AddComponentMenu("")]
[FlowNode.Pin(0, "Released", FlowNode.PinTypes.Output, 0)]
public class FlowNode_OnPointerRelease : FlowNodePersistent
{
  [Token(Token = "0x400089D")]
  [FieldOffset(Offset = "0x18")]
  private bool mPressed;

  [Token(Token = "0x6000B1D")]
  [Address(RVA = "0xAE7870", Offset = "0xAE6670", VA = "0x10AE7870")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000B1E")]
  [Address(RVA = "0x107AED0", Offset = "0x1079CD0", VA = "0x1107AED0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000B1F")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_OnPointerRelease()
  {
  }
}
