// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001820")]
  [FlowNode.Pin(101, "End", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Begin", FlowNode.PinTypes.Input, 1)]
  public abstract class FlowNode_ReqRaidBase : FlowNode_Network
  {
    [Token(Token = "0x40056BC")]
    protected const int PIN_INPUT_BEGIN_API = 1;
    [Token(Token = "0x40056BD")]
    protected const int PIN_OUTPUT_END_API = 101;
    [Token(Token = "0x40056BE")]
    protected const int PIN_OUTPUT_TIME_OVER = 201;
    [Token(Token = "0x40056BF")]
    protected const int PIN_OUTPUT_ALREADY_BEAT = 202;
    [Token(Token = "0x40056C0")]
    protected const int PIN_OUTPUT_RESCUE_DAMAGE_ZERO = 203;
    [Token(Token = "0x40056C1")]
    protected const int PIN_OUTPUT_RESCUE_PLAYER_LEVEL_SHORT = 204;

    [Token(Token = "0x600615E")]
    public abstract WebAPI GenerateWebAPI();

    [Token(Token = "0x600615F")]
    public abstract bool Success(WWWResult www);

    [Token(Token = "0x6006160")]
    [Address(RVA = "0x135FD20", Offset = "0x135EB20", VA = "0x1135FD20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006161")]
    [Address(RVA = "0x135FDA0", Offset = "0x135EBA0", VA = "0x1135FDA0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006162")]
    [Address(RVA = "0x135FC20", Offset = "0x135EA20", VA = "0x1135FC20")]
    private void BackHome(GameObject go)
    {
    }

    [Token(Token = "0x6006163")]
    [Address(RVA = "0x135FCA0", Offset = "0x135EAA0", VA = "0x1135FCA0")]
    private void BackRestore(GameObject go)
    {
    }

    [Token(Token = "0x6006164")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    protected FlowNode_ReqRaidBase()
    {
    }
  }
}
