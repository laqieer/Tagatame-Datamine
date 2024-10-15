// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqInspSkillReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200173D")]
  [FlowNode.Pin(201, "コスト不足(GOLD)", FlowNode.PinTypes.Output, 201)]
  [FlowNode.NodeType("InspSkill/Req/Reset", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(202, "コスト不足(COIN)", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(203, "コスト不足(COIN_P)", FlowNode.PinTypes.Output, 203)]
  [AddComponentMenu("")]
  public class FlowNode_ReqInspSkillReset : FlowNode_Network
  {
    [Token(Token = "0x4005392")]
    protected const int PIN_INPUT_REQUEST = 1;
    [Token(Token = "0x4005393")]
    protected const int PIN_OUTPUT_SUCCESS = 101;
    [Token(Token = "0x4005394")]
    protected const int PIN_OUTPUT_COSTSHORT_GOLD = 201;
    [Token(Token = "0x4005395")]
    protected const int PIN_OUTPUT_COSTSHORT_COIN = 202;
    [Token(Token = "0x4005396")]
    protected const int PIN_OUTPUT_COSTSHORT_COIN_P = 203;

    [Token(Token = "0x6005E87")]
    [Address(RVA = "0x133AD20", Offset = "0x1339B20", VA = "0x1133AD20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E88")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E89")]
    [Address(RVA = "0x133AC40", Offset = "0x1339A40", VA = "0x1133AC40")]
    private void CostShort()
    {
    }

    [Token(Token = "0x6005E8A")]
    [Address(RVA = "0x133AF60", Offset = "0x1339D60", VA = "0x1133AF60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E8B")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqInspSkillReset()
    {
    }
  }
}
