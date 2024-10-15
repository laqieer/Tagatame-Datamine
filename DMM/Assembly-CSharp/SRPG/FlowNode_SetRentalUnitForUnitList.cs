// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetRentalUnitForUnitList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018AB")]
  [FlowNode.NodeType("UnitRental/SetRentalUnitForUnitList", 32741)]
  [FlowNode.Pin(1, "Set", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Finish", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(20, "Error", FlowNode.PinTypes.Output, 20)]
  [AddComponentMenu("")]
  public class FlowNode_SetRentalUnitForUnitList : FlowNode
  {
    [Token(Token = "0x4005880")]
    private const int PIN_IN_SET = 1;
    [Token(Token = "0x4005881")]
    private const int PIN_OUT_TO_UNIT = 10;
    [Token(Token = "0x4005882")]
    private const int PIN_OUT_ERROR = 20;

    [Token(Token = "0x6006339")]
    [Address(RVA = "0x315B20", Offset = "0x314920", VA = "0x10315B20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600633A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetRentalUnitForUnitList()
    {
    }
  }
}
