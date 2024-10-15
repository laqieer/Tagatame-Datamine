// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGenesisRaidboss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001697")]
  [FlowNode.Pin(102, "OutOfPeriod", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Genesis/Req/Raidboss", 32741)]
  public class FlowNode_ReqGenesisRaidboss : FlowNode_Network
  {
    [Token(Token = "0x4005219")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400521A")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400521B")]
    protected const int PIN_OUT_OUT_OF_PERIOD = 102;

    [Token(Token = "0x6005CA2")]
    [Address(RVA = "0x130A640", Offset = "0x1309440", VA = "0x1130A640", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CA3")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005CA4")]
    [Address(RVA = "0x130A730", Offset = "0x1309530", VA = "0x1130A730", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005CA5")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGenesisRaidboss()
    {
    }
  }
}
