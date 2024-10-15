// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GetShopType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013F9")]
  [FlowNode.Pin(1, "Test", FlowNode.PinTypes.Input, 1000)]
  [FlowNode.Pin(109, "Limited", FlowNode.PinTypes.Output, 9)]
  [FlowNode.Pin(100, "Normal", FlowNode.PinTypes.Output, 0)]
  [FlowNode.NodeType("System/Shop/GetShopType", 32741)]
  [FlowNode.Pin(103, "Monozuki", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(104, "Arena", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(105, "Tour", FlowNode.PinTypes.Output, 5)]
  [FlowNode.Pin(106, "Multi", FlowNode.PinTypes.Output, 6)]
  [FlowNode.Pin(107, "AwakePiece", FlowNode.PinTypes.Output, 7)]
  [FlowNode.Pin(108, "Artifact", FlowNode.PinTypes.Output, 8)]
  [FlowNode.Pin(101, "Tabi", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(102, "Kimagure", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  [FlowNode.Pin(111, "Port", FlowNode.PinTypes.Output, 111)]
  public class FlowNode_GetShopType : FlowNode
  {
    [Token(Token = "0x40049F1")]
    private const int PIN_OUT_SHOP_PORT = 111;

    [Token(Token = "0x6005394")]
    [Address(RVA = "0x1281B60", Offset = "0x1280960", VA = "0x11281B60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005395")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GetShopType()
    {
    }
  }
}
