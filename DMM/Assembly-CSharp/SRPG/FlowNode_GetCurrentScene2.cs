// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GetCurrentScene2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013F5")]
  [FlowNode.Pin(106, "Unknown", FlowNode.PinTypes.Output, 106)]
  [FlowNode.Pin(105, "Title", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(110, "Cancel", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(102, "Multi", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "Single", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "Other", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("Scene/GetCurrentScene2", 32741)]
  [FlowNode.Pin(104, "Home", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(103, "HomeMulti", FlowNode.PinTypes.Output, 103)]
  public class FlowNode_GetCurrentScene2 : FlowNode
  {
    [Token(Token = "0x40049ED")]
    [FieldOffset(Offset = "0x18")]
    public string HomeString;
    [Token(Token = "0x40049EE")]
    [FieldOffset(Offset = "0x1C")]
    public string TownString;

    [Token(Token = "0x600538C")]
    [Address(RVA = "0x1281530", Offset = "0x1280330", VA = "0x11281530", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600538D")]
    [Address(RVA = "0x1281810", Offset = "0x1280610", VA = "0x11281810")]
    public FlowNode_GetCurrentScene2()
    {
    }
  }
}
