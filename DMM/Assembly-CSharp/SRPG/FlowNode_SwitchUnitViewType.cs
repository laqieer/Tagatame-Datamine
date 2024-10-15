// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SwitchUnitViewType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001899")]
  [FlowNode.NodeType("UnitInventory/SwitchUnitViewType", 32741)]
  [FlowNode.Pin(0, "switch(UnitEnhanceV3.eUnitViewType)", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "case 3Dモード:", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "case 3Dモード(ユニット非表示):", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "case 2Dモード:", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "case 2Dモード(ユニット非表示):", FlowNode.PinTypes.Output, 103)]
  [AddComponentMenu("")]
  public class FlowNode_SwitchUnitViewType : FlowNode
  {
    [Token(Token = "0x4005844")]
    private const int PIN_IN_SWITCH = 0;
    [Token(Token = "0x4005845")]
    private const int PIN_OUT_CASE_3D = 100;
    [Token(Token = "0x4005846")]
    private const int PIN_OUT_CASE_3D_HIDE_UNIT = 101;
    [Token(Token = "0x4005847")]
    private const int PIN_OUT_CASE_2D = 102;
    [Token(Token = "0x4005848")]
    private const int PIN_OUT_CASE_2D_HIDE_UNIT = 103;

    [Token(Token = "0x600630A")]
    [Address(RVA = "0x315CE0", Offset = "0x314AE0", VA = "0x10315CE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600630B")]
    [Address(RVA = "0x315E00", Offset = "0x314C00", VA = "0x10315E00")]
    private void OnSwitch()
    {
    }

    [Token(Token = "0x600630C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SwitchUnitViewType()
    {
    }
  }
}
