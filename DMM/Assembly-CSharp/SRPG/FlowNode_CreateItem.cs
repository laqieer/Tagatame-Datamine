// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CreateItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013B4")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Unit/CreateEquipItem", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "ワンタップ合成", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(4, "素材が足りない", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(3, "費用が足りない", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(2, "所持限界に達している", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_CreateItem : FlowNode_Network
  {
    [Token(Token = "0x40048EB")]
    [FieldOffset(Offset = "0x20")]
    private ItemParam mItemParam;

    [Token(Token = "0x6005274")]
    [Address(RVA = "0x12733F0", Offset = "0x12721F0", VA = "0x112733F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005275")]
    [Address(RVA = "0x12732D0", Offset = "0x12720D0", VA = "0x112732D0")]
    public void CallApi(NeedEquipItemList need_euip_item, PlayerData player)
    {
    }

    [Token(Token = "0x6005276")]
    [Address(RVA = "0x12731C0", Offset = "0x1271FC0", VA = "0x112731C0")]
    public void CallApiNormal(PlayerData player, CreateItemResult result_type)
    {
    }

    [Token(Token = "0x6005277")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005278")]
    [Address(RVA = "0x1273A00", Offset = "0x1272800", VA = "0x11273A00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005279")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_CreateItem()
    {
    }
  }
}
