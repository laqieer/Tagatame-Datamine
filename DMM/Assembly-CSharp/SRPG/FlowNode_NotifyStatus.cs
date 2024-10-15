// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_NotifyStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001448")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Disable", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "output", FlowNode.PinTypes.Output, 10)]
  [FlowNode.NodeType("System/Notify/Status", 32741)]
  [FlowNode.Pin(0, "Enable", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_NotifyStatus : FlowNode
  {
    [Token(Token = "0x4004B04")]
    private const int PIN_ENABLE = 0;
    [Token(Token = "0x4004B05")]
    private const int PIN_DISABLE = 1;
    [Token(Token = "0x4004B06")]
    private const int PIN_OUTPUT = 10;

    [Token(Token = "0x60054C4")]
    [Address(RVA = "0x1293510", Offset = "0x1292310", VA = "0x11293510", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60054C5")]
    [Address(RVA = "0x7BFE80", Offset = "0x7BEC80", VA = "0x107BFE80")]
    public void NotifyEnable()
    {
    }

    [Token(Token = "0x60054C6")]
    [Address(RVA = "0x12934E0", Offset = "0x12922E0", VA = "0x112934E0")]
    public void NotifyDisable()
    {
    }

    [Token(Token = "0x60054C7")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_NotifyStatus()
    {
    }
  }
}
