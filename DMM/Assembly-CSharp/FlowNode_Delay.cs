// Decompiled with JetBrains decompiler
// Type: FlowNode_Delay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001D0")]
[AddComponentMenu("")]
[FlowNode.NodeType("Common/Delay", 32741)]
[FlowNode.Pin(10, "Start", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(11, "Cancel", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(1, "Finished", FlowNode.PinTypes.Output, 2)]
[FlowNode.Pin(2, "Cancelled", FlowNode.PinTypes.Output, 3)]
public class FlowNode_Delay : FlowNode
{
  [Token(Token = "0x4000844")]
  [FieldOffset(Offset = "0x18")]
  public float Timer;
  [Token(Token = "0x4000845")]
  [FieldOffset(Offset = "0x1C")]
  private float mTimer;
  [Token(Token = "0x4000846")]
  [FieldOffset(Offset = "0x20")]
  public bool UnscaledTime;

  [Token(Token = "0x6000A89")]
  [Address(RVA = "0xF49400", Offset = "0xF48200", VA = "0x10F49400", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A8A")]
  [Address(RVA = "0xF49480", Offset = "0xF48280", VA = "0x10F49480")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A8B")]
  [Address(RVA = "0xF494E0", Offset = "0xF482E0", VA = "0x10F494E0")]
  public FlowNode_Delay()
  {
  }
}
