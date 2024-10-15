// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckUnitRentalLeave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200189F")]
  [FlowNode.NodeType("UnitRental/Check/Leave", 32741)]
  [FlowNode.Pin(111, "Yes", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(112, "No", FlowNode.PinTypes.Output, 112)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "IsExist", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_CheckUnitRentalLeave : FlowNode
  {
    [Token(Token = "0x4005863")]
    private const int PIN_IN_IS_EXIST = 1;
    [Token(Token = "0x4005864")]
    private const int PIN_OUT_YES = 111;
    [Token(Token = "0x4005865")]
    private const int PIN_OUT_NO = 112;

    [Token(Token = "0x6006319")]
    [Address(RVA = "0x306610", Offset = "0x305410", VA = "0x10306610", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600631A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckUnitRentalLeave()
    {
    }
  }
}
