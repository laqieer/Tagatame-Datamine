﻿// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCombatPowerPlayerRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200131E")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("CombatPower/Req/ReqCombatPowerPlayerRanking", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqCombatPowerPlayerRanking : FlowNode_Network
  {
    [Token(Token = "0x40046F2")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40046F3")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x40046F4")]
    public const string KEY_REQ_COMBATPOWERRANKING = "KEY_REQ_COMBATPOWERRANKING";
    [Token(Token = "0x40046F5")]
    public const string KEY_REQUEASTDATA = "KEY_REQUEASTDATA";

    [Token(Token = "0x600509A")]
    [Address(RVA = "0x1259290", Offset = "0x1258090", VA = "0x11259290", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600509B")]
    [Address(RVA = "0x12596C0", Offset = "0x12584C0", VA = "0x112596C0")]
    private void Success(SerializeValueList _valueList = null)
    {
    }

    [Token(Token = "0x600509C")]
    [Address(RVA = "0x12593F0", Offset = "0x12581F0", VA = "0x112593F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600509D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCombatPowerPlayerRanking()
    {
    }
  }
}