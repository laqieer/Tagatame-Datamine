// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_NetworkReachability
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200143F")]
  [FlowNode.Pin(4, "Not Connected", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "Wifi", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("Network/NetworkReachability", 32741)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(3, "Carrier", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_NetworkReachability : FlowNode
  {
    [Token(Token = "0x4004AED")]
    private const int PIN_ID_IN = 1;
    [Token(Token = "0x4004AEE")]
    private const int PIN_ID_WIFI = 2;
    [Token(Token = "0x4004AEF")]
    private const int PIN_ID_CARRIER = 3;
    [Token(Token = "0x4004AF0")]
    private const int PIN_ID_NOT_CONNECTED = 4;

    [Token(Token = "0x60054A5")]
    [Address(RVA = "0x1291120", Offset = "0x128FF20", VA = "0x11291120", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60054A6")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_NetworkReachability()
    {
    }
  }
}
