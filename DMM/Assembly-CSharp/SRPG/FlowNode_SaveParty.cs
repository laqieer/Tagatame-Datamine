// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SaveParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015FB")]
  [FlowNode.NodeType("UI/SaveParty", 32741)]
  [FlowNode.Pin(51, "ResetWithID", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(50, "SaveWithID", FlowNode.PinTypes.Input, 50)]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(200, "OutSaveWithID", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(201, "OutResetWithID", FlowNode.PinTypes.Output, 201)]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "Reset", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Save", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_SaveParty : FlowNode
  {
    [Token(Token = "0x4004FBC")]
    [FieldOffset(Offset = "0x18")]
    private long[,] mSavedUnits;
    [Token(Token = "0x4004FBD")]
    [FieldOffset(Offset = "0x1C")]
    private int mSavedPartyID;
    [Token(Token = "0x4004FBE")]
    [FieldOffset(Offset = "0x20")]
    private ItemData[] mSavedInventory;

    [Token(Token = "0x6005A75")]
    [Address(RVA = "0x12F2B90", Offset = "0x12F1990", VA = "0x112F2B90")]
    private void Save()
    {
    }

    [Token(Token = "0x6005A76")]
    [Address(RVA = "0x12F29C0", Offset = "0x12F17C0", VA = "0x112F29C0")]
    private void Reset()
    {
    }

    [Token(Token = "0x6005A77")]
    [Address(RVA = "0x12F2AB0", Offset = "0x12F18B0", VA = "0x112F2AB0")]
    private void SaveInventory()
    {
    }

    [Token(Token = "0x6005A78")]
    [Address(RVA = "0x12F2940", Offset = "0x12F1740", VA = "0x112F2940")]
    private void ResetInventory()
    {
    }

    [Token(Token = "0x6005A79")]
    [Address(RVA = "0x12F2660", Offset = "0x12F1460", VA = "0x112F2660", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A7A")]
    [Address(RVA = "0x12F2C80", Offset = "0x12F1A80", VA = "0x112F2C80")]
    public FlowNode_SaveParty()
    {
    }
  }
}
