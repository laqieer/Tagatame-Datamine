// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckUnitRentalHave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200189E")]
  [AddComponentMenu("")]
  [FlowNode.Pin(111, "Yes", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(1, "Have", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("UnitRental/Check/HaveRentalUnit", 32741)]
  [FlowNode.Pin(112, "No", FlowNode.PinTypes.Output, 112)]
  public class FlowNode_CheckUnitRentalHave : FlowNode
  {
    [Token(Token = "0x4005860")]
    private const int PIN_IN_IS_HAVE = 1;
    [Token(Token = "0x4005861")]
    private const int PIN_OUT_YES = 111;
    [Token(Token = "0x4005862")]
    private const int PIN_OUT_NO = 112;

    [Token(Token = "0x6006317")]
    [Address(RVA = "0x306560", Offset = "0x305360", VA = "0x10306560", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006318")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckUnitRentalHave()
    {
    }
  }
}
