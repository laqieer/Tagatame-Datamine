// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTobiraEnhance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015A0")]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "扉を強化した", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "扉を強化する", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Unit/ReqTobira/ReqTobiraEnhance", 32741)]
  public class FlowNode_ReqTobiraEnhance : FlowNode_Network
  {
    [Token(Token = "0x4004E96")]
    private const int INPUT_REQUEST = 0;
    [Token(Token = "0x4004E97")]
    private const int OUTPUT_REQUEST = 100;

    [Token(Token = "0x6005919")]
    [Address(RVA = "0x12DF1F0", Offset = "0x12DDFF0", VA = "0x112DF1F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600591A")]
    [Address(RVA = "0x12DF330", Offset = "0x12DE130", VA = "0x112DF330", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600591B")]
    [Address(RVA = "0x12C3F80", Offset = "0x12C2D80", VA = "0x112C3F80")]
    private void EnhanceTobiraCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600591C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTobiraEnhance()
    {
    }
  }
}
