// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SellItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001605")]
  [FlowNode.Pin(120, "ゼニー上限超えで売却不可", FlowNode.PinTypes.Output, 20)]
  [FlowNode.NodeType("System/Shop/SellItem", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "RequestConvert", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_SellItem : FlowNode_Network
  {
    [Token(Token = "0x4004FDE")]
    private const int PIN_OT_SHOP_REACHED_MAX_ZENNY = 120;

    [Token(Token = "0x6005A8E")]
    [Address(RVA = "0x12F4BB0", Offset = "0x12F39B0", VA = "0x112F4BB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A8F")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005A90")]
    [Address(RVA = "0x12F4F90", Offset = "0x12F3D90", VA = "0x112F4F90", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005A91")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_SellItem()
    {
    }
  }
}
