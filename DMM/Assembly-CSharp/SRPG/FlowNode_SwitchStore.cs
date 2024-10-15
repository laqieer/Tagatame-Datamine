// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SwitchStore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001646")]
  [FlowNode.Pin(102, "GooglePlay", FlowNode.PinTypes.Output, 102)]
  [FlowNode.NodeType("Platform/SwitchStore", 32741)]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(101, "iOS", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(103, "DMM", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(104, "AU", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(105, "EDITOR", FlowNode.PinTypes.Output, 105)]
  [AddComponentMenu("")]
  public class FlowNode_SwitchStore : FlowNode
  {
    [Token(Token = "0x40050E4")]
    private const int PIN_INPUT = 0;
    [Token(Token = "0x40050E5")]
    private const int PIN_PLATFORM_IOS = 101;
    [Token(Token = "0x40050E6")]
    private const int PIN_PLATFORM_GOOGLE = 102;
    [Token(Token = "0x40050E7")]
    private const int PIN_PLATFORM_DMM = 103;
    [Token(Token = "0x40050E8")]
    private const int PIN_PLATFORM_AU = 104;
    [Token(Token = "0x40050E9")]
    private const int PIN_PLATFORM_EDITOR = 105;

    [Token(Token = "0x6005B92")]
    [Address(RVA = "0x12986C0", Offset = "0x12974C0", VA = "0x112986C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B93")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SwitchStore()
    {
    }
  }
}
