// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckUnitRentalReturnItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018A2")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "IsExist", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(112, "No", FlowNode.PinTypes.Output, 112)]
  [FlowNode.NodeType("UnitRental/Check/ReturnItem", 32741)]
  [FlowNode.Pin(111, "Yes", FlowNode.PinTypes.Output, 111)]
  public class FlowNode_CheckUnitRentalReturnItem : FlowNode
  {
    [Token(Token = "0x400586E")]
    private const int PIN_IN_IS_EXIST = 1;
    [Token(Token = "0x400586F")]
    private const int PIN_OUT_YES = 111;
    [Token(Token = "0x4005870")]
    private const int PIN_OUT_NO = 112;

    [Token(Token = "0x600631F")]
    [Address(RVA = "0x306AB0", Offset = "0x3058B0", VA = "0x10306AB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006320")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckUnitRentalReturnItem()
    {
    }
  }
}
