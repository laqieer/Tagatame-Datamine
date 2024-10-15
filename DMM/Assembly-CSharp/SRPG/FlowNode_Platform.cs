// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Platform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001456")]
  [FlowNode.Pin(104, "EDITOR", FlowNode.PinTypes.Output, 104)]
  [AddComponentMenu("")]
  [FlowNode.Pin(103, "DMM", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(101, "iOS", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Platform/Switch", 32741)]
  [FlowNode.Pin(102, "Android", FlowNode.PinTypes.Output, 102)]
  public class FlowNode_Platform : FlowNode
  {
    [Token(Token = "0x4004B38")]
    private const int PIN_PLATFORM_IOS = 101;
    [Token(Token = "0x4004B39")]
    private const int PIN_PLATFORM_ANDROID = 102;
    [Token(Token = "0x4004B3A")]
    private const int PIN_PLATFORM_DMM = 103;
    [Token(Token = "0x4004B3B")]
    private const int PIN_PLATFORM_EDITOR = 104;

    [Token(Token = "0x6005522")]
    [Address(RVA = "0x12986C0", Offset = "0x12974C0", VA = "0x112986C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005523")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_Platform()
    {
    }
  }
}
