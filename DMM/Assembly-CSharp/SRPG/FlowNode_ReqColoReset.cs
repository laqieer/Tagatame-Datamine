// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqColoReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014CA")]
  [FlowNode.NodeType("Network/btl_colo_reset", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_ReqColoReset : FlowNode_Network
  {
    [Token(Token = "0x4004C49")]
    [FieldOffset(Offset = "0x20")]
    public ColoResetTypes ResetType;

    [Token(Token = "0x600569B")]
    [Address(RVA = "0x12C1070", Offset = "0x12BFE70", VA = "0x112C1070", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600569C")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x600569D")]
    [Address(RVA = "0x12C1170", Offset = "0x12BFF70", VA = "0x112C1170", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600569E")]
    [Address(RVA = "0x2B8A30", Offset = "0x2B7830", VA = "0x102B8A30")]
    private int getRequiredCoin() => new int();

    [Token(Token = "0x600569F")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqColoReset()
    {
    }
  }
}
