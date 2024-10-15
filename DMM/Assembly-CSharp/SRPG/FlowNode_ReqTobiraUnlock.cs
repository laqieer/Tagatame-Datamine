// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTobiraUnlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015A4")]
  [FlowNode.NodeType("System/Unit/ReqTobira/Unlock")]
  [FlowNode.Pin(100, "扉機能を解放した", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "扉機能を解放する", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  public class FlowNode_ReqTobiraUnlock : FlowNode_Network
  {
    [Token(Token = "0x4004E9E")]
    public const int INPUT_REQUEST = 0;
    [Token(Token = "0x4004E9F")]
    public const int OUTPUT_REQUEST = 100;

    [Token(Token = "0x6005926")]
    [Address(RVA = "0x12E01F0", Offset = "0x12DEFF0", VA = "0x112E01F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005927")]
    [Address(RVA = "0x12E02F0", Offset = "0x12DF0F0", VA = "0x112E02F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005928")]
    [Address(RVA = "0x12C3F80", Offset = "0x12C2D80", VA = "0x112C3F80")]
    private void TobiraUnlockCallback(WWWResult www)
    {
    }

    [Token(Token = "0x6005929")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTobiraUnlock()
    {
    }
  }
}
