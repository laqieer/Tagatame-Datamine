// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqDecideTutorialGacha
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014E8")]
  [FlowNode.Pin(11, "Failed", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Gacha/ReqDecideTutorialGacha")]
  public class FlowNode_ReqDecideTutorialGacha : FlowNode_Network
  {
    [Token(Token = "0x4004C9C")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x4004C9D")]
    private const int PIN_OU_SUCCESS = 10;
    [Token(Token = "0x4004C9E")]
    private const int PIN_OU_FAILED = 11;

    [Token(Token = "0x60056F3")]
    [Address(RVA = "0x12C6AD0", Offset = "0x12C58D0", VA = "0x112C6AD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056F4")]
    [Address(RVA = "0x12C6B10", Offset = "0x12C5910", VA = "0x112C6B10", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056F5")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x60056F6")]
    [Address(RVA = "0x127E1B0", Offset = "0x127CFB0", VA = "0x1127E1B0")]
    private void Failure()
    {
    }

    [Token(Token = "0x60056F7")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqDecideTutorialGacha()
    {
    }
  }
}
