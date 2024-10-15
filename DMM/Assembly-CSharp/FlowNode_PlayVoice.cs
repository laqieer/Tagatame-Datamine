// Decompiled with JetBrains decompiler
// Type: FlowNode_PlayVoice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000205")]
[AddComponentMenu("")]
[FlowNode.Pin(100, "OneShot", FlowNode.PinTypes.Input, 0)]
[FlowNode.NodeType("Sound/PlayVoice", 32741)]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
public class FlowNode_PlayVoice : FlowNode
{
  [Token(Token = "0x40008E6")]
  [FieldOffset(Offset = "0x18")]
  public string charaName;
  [Token(Token = "0x40008E7")]
  [FieldOffset(Offset = "0x1C")]
  public string cueID;

  [Token(Token = "0x6000B52")]
  [Address(RVA = "0x107DA80", Offset = "0x107C880", VA = "0x1107DA80", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B53")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_PlayVoice()
  {
  }
}
