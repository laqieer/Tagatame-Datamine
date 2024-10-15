// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckOldData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001382")]
  [AddComponentMenu("")]
  [FlowNode.Pin(202, "Finish", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(200, "Exist", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(201, "Not Exist", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(101, "Delete", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Check/CheckOldData", 32741)]
  [FlowNode.Pin(100, "Check", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_CheckOldData : FlowNode
  {
    [Token(Token = "0x40047FC")]
    [FieldOffset(Offset = "0x18")]
    private readonly int PINID_CHECK;
    [Token(Token = "0x40047FD")]
    [FieldOffset(Offset = "0x1C")]
    private readonly int PINID_DELETE;
    [Token(Token = "0x40047FE")]
    [FieldOffset(Offset = "0x20")]
    private readonly int PINID_EXIST;
    [Token(Token = "0x40047FF")]
    [FieldOffset(Offset = "0x24")]
    private readonly int PINID_NOT_EXIST;
    [Token(Token = "0x4004800")]
    [FieldOffset(Offset = "0x28")]
    private readonly int PINID_FINISH;

    [Token(Token = "0x60051D0")]
    [Address(RVA = "0x126BFE0", Offset = "0x126ADE0", VA = "0x1126BFE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051D1")]
    [Address(RVA = "0x126BEB0", Offset = "0x126ACB0", VA = "0x1126BEB0")]
    private IEnumerator DeleteOldData() => (IEnumerator) null;

    [Token(Token = "0x60051D2")]
    [Address(RVA = "0x126BF20", Offset = "0x126AD20", VA = "0x1126BF20")]
    public static void DeleteThread(object param)
    {
    }

    [Token(Token = "0x60051D3")]
    [Address(RVA = "0x126BF80", Offset = "0x126AD80", VA = "0x1126BF80")]
    private bool IsExist() => new bool();

    [Token(Token = "0x60051D4")]
    [Address(RVA = "0x126C190", Offset = "0x126AF90", VA = "0x1126C190")]
    public FlowNode_CheckOldData()
    {
    }
  }
}
