// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MediaPlayerDispatchFinishEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200142D")]
  [FlowNode.Pin(10, "Output", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("AVProVideo/MediaPlayerDispatchFinishEvent")]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_MediaPlayerDispatchFinishEvent : FlowNode
  {
    [Token(Token = "0x4004AB3")]
    [FieldOffset(Offset = "0x18")]
    public FlowNode_MediaPlayerDispatchFinishEvent.OnEnd onEnd;

    [Token(Token = "0x6005444")]
    [Address(RVA = "0x128E9D0", Offset = "0x128D7D0", VA = "0x1128E9D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005445")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MediaPlayerDispatchFinishEvent()
    {
    }

    [Token(Token = "0x200142E")]
    public delegate void OnEnd();
  }
}
