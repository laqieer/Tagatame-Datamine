// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_LimitedShopCheckBoughtItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200141A")]
  [FlowNode.NodeType("SRPG/LimitedShopCheckBoughtItem", 32741)]
  [FlowNode.Pin(1, "", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "SetItem", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Item", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "Error", FlowNode.PinTypes.Output, 12)]
  [AddComponentMenu("")]
  public class FlowNode_LimitedShopCheckBoughtItem : FlowNode
  {
    [Token(Token = "0x60053FC")]
    [Address(RVA = "0x12878F0", Offset = "0x12866F0", VA = "0x112878F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053FD")]
    [Address(RVA = "0x1287A70", Offset = "0x1286870", VA = "0x11287A70")]
    private void SetResult()
    {
    }

    [Token(Token = "0x60053FE")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_LimitedShopCheckBoughtItem()
    {
    }
  }
}
