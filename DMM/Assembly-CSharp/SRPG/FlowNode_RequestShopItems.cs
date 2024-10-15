// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RequestShopItems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015CE")]
  [FlowNode.NodeType("System/Shop/RequestShopItems", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(100, "ショップ期間外", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_RequestShopItems : FlowNode_Network
  {
    [Token(Token = "0x4004F50")]
    private const int PIN_OUT_SHOP_BUY_OUTOF_PERIOD = 100;
    [Token(Token = "0x4004F51")]
    [FieldOffset(Offset = "0x20")]
    private EShopType mShopType;

    [Token(Token = "0x60059A6")]
    [Address(RVA = "0x12EAA60", Offset = "0x12E9860", VA = "0x112EAA60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60059A7")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60059A8")]
    [Address(RVA = "0x12EAC20", Offset = "0x12E9A20", VA = "0x112EAC20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60059A9")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_RequestShopItems()
    {
    }
  }
}
