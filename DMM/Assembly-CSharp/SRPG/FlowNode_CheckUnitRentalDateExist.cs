// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckUnitRentalDateExist
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200189C")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("UnitRental/Check/DateExist", 32741)]
  [FlowNode.Pin(1, "IsExist", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(112, "No", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(111, "Yes", FlowNode.PinTypes.Output, 111)]
  public class FlowNode_CheckUnitRentalDateExist : FlowNode
  {
    [Token(Token = "0x400585A")]
    private const int PIN_IN_IS_EXIST = 1;
    [Token(Token = "0x400585B")]
    private const int PIN_OUT_YES = 111;
    [Token(Token = "0x400585C")]
    private const int PIN_OUT_NO = 112;

    [Token(Token = "0x6006313")]
    [Address(RVA = "0x3063E0", Offset = "0x3051E0", VA = "0x103063E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006314")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckUnitRentalDateExist()
    {
    }
  }
}
