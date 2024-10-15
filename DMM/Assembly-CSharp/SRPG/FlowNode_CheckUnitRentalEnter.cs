// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckUnitRentalEnter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200189D")]
  [FlowNode.NodeType("UnitRental/Check/Enter", 32741)]
  [FlowNode.Pin(1, "IsExist", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(111, "Yes", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(112, "No", FlowNode.PinTypes.Output, 112)]
  [AddComponentMenu("")]
  public class FlowNode_CheckUnitRentalEnter : FlowNode
  {
    [Token(Token = "0x400585D")]
    private const int PIN_IN_IS_EXIST = 1;
    [Token(Token = "0x400585E")]
    private const int PIN_OUT_YES = 111;
    [Token(Token = "0x400585F")]
    private const int PIN_OUT_NO = 112;

    [Token(Token = "0x6006315")]
    [Address(RVA = "0x306480", Offset = "0x305280", VA = "0x10306480", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006316")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckUnitRentalEnter()
    {
    }
  }
}
