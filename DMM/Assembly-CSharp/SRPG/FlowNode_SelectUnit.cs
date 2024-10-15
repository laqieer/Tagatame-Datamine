// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SelectUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001604")]
  [FlowNode.NodeType("System/Unit/SelectUnit", 32741)]
  [FlowNode.Pin(1, "Selected", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "Unit Not Found", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Select", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_SelectUnit : FlowNode
  {
    [Token(Token = "0x4004FD7")]
    [FieldOffset(Offset = "0x18")]
    public string UnitID;
    [Token(Token = "0x4004FD8")]
    [FieldOffset(Offset = "0x20")]
    public long UniqueID;
    [Token(Token = "0x4004FD9")]
    [FieldOffset(Offset = "0x28")]
    public bool KeepSelection;
    [Token(Token = "0x4004FDA")]
    [FieldOffset(Offset = "0x29")]
    public bool SelectJob;
    [Token(Token = "0x4004FDB")]
    [FieldOffset(Offset = "0x2C")]
    public string JobID;
    [Token(Token = "0x4004FDC")]
    [FieldOffset(Offset = "0x30")]
    public bool SelectEquipSlot;
    [Token(Token = "0x4004FDD")]
    [FieldOffset(Offset = "0x34")]
    public int EquipSlot;

    [Token(Token = "0x6005A8C")]
    [Address(RVA = "0x12F41D0", Offset = "0x12F2FD0", VA = "0x112F41D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A8D")]
    [Address(RVA = "0x12F4540", Offset = "0x12F3340", VA = "0x112F4540")]
    public FlowNode_SelectUnit()
    {
    }
  }
}
