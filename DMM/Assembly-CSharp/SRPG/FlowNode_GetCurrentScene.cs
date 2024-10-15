// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GetCurrentScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013F4")]
  [FlowNode.Pin(0, "Test", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Other", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("")]
  [FlowNode.Pin(105, "Title", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(104, "Home", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(103, "HomeMulti", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(102, "Multi", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(101, "Single", FlowNode.PinTypes.Output, 0)]
  [FlowNode.NodeType("Scene/GetCurrentScene", 32741)]
  public class FlowNode_GetCurrentScene : FlowNode
  {
    [Token(Token = "0x6005389")]
    [Address(RVA = "0x1281880", Offset = "0x1280680", VA = "0x11281880")]
    public static bool IsAfterLogin() => new bool();

    [Token(Token = "0x600538A")]
    [Address(RVA = "0x12818D0", Offset = "0x12806D0", VA = "0x112818D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600538B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GetCurrentScene()
    {
    }
  }
}
