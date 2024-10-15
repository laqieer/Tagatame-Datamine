// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckUnitRentalMaxFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018A0")]
  [FlowNode.NodeType("UnitRental/Check/MaxFavorite", 32741)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(111, "Max", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(112, "NoMax", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(113, "NotFoundUnit", FlowNode.PinTypes.Output, 113)]
  [AddComponentMenu("")]
  public class FlowNode_CheckUnitRentalMaxFavorite : FlowNode
  {
    [Token(Token = "0x4005866")]
    private const int PIN_IN_COMP = 1;
    [Token(Token = "0x4005867")]
    private const int PIN_OUT_MAX = 111;
    [Token(Token = "0x4005868")]
    private const int PIN_OUT_NO_MAX = 112;
    [Token(Token = "0x4005869")]
    private const int PIN_OUT_NOT_FOUND_UNIT = 113;
    [Token(Token = "0x400586A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool IsCheckExpire;

    [Token(Token = "0x600631B")]
    [Address(RVA = "0x3066F0", Offset = "0x3054F0", VA = "0x103066F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600631C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckUnitRentalMaxFavorite()
    {
    }
  }
}
