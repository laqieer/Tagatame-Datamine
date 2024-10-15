// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckUnitRentalQuestActive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018A1")]
  [AddComponentMenu("")]
  [FlowNode.Pin(111, "Yes", FlowNode.PinTypes.Output, 111)]
  [FlowNode.NodeType("UnitRental/Check/RentalQuestActive", 32741)]
  [FlowNode.Pin(1, "IsActive", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(112, "No", FlowNode.PinTypes.Output, 112)]
  public class FlowNode_CheckUnitRentalQuestActive : FlowNode
  {
    [Token(Token = "0x400586B")]
    private const int PIN_IN_IS_ACTIVE = 1;
    [Token(Token = "0x400586C")]
    private const int PIN_OUT_YES = 111;
    [Token(Token = "0x400586D")]
    private const int PIN_OUT_NO = 112;

    [Token(Token = "0x600631D")]
    [Address(RVA = "0x306820", Offset = "0x305620", VA = "0x10306820", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600631E")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckUnitRentalQuestActive()
    {
    }
  }
}
