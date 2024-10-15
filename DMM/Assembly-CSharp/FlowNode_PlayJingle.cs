// Decompiled with JetBrains decompiler
// Type: FlowNode_PlayJingle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000202")]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
[AddComponentMenu("")]
[FlowNode.NodeType("Sound/PlayJingle", 32741)]
[FlowNode.Pin(100, "OneShot", FlowNode.PinTypes.Input, 0)]
public class FlowNode_PlayJingle : FlowNode
{
  [Token(Token = "0x40008CB")]
  [FieldOffset(Offset = "0x18")]
  public string cueID;

  [Token(Token = "0x6000B47")]
  [Address(RVA = "0x107D3B0", Offset = "0x107C1B0", VA = "0x1107D3B0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B48")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_PlayJingle()
  {
  }
}
