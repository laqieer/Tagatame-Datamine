// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTobiraOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015A3")]
  [FlowNode.Pin(0, "扉を解放する", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "扉を解放した", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/Unit/ReqTobira/ReqTobiraOpen")]
  public class FlowNode_ReqTobiraOpen : FlowNode_Network
  {
    [Token(Token = "0x4004E9C")]
    public const int INPUT_REQUEST = 0;
    [Token(Token = "0x4004E9D")]
    public const int OUTPUT_REQUEST = 100;

    [Token(Token = "0x6005922")]
    [Address(RVA = "0x12DFDE0", Offset = "0x12DEBE0", VA = "0x112DFDE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005923")]
    [Address(RVA = "0x12DFF00", Offset = "0x12DED00", VA = "0x112DFF00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005924")]
    [Address(RVA = "0x12C3F80", Offset = "0x12C2D80", VA = "0x112C3F80")]
    private void TobiraOpenCallback(WWWResult www)
    {
    }

    [Token(Token = "0x6005925")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTobiraOpen()
    {
    }
  }
}
