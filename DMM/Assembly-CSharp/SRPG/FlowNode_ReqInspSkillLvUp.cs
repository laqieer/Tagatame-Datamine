// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqInspSkillLvUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001739")]
  [FlowNode.Pin(201, "コスト不足", FlowNode.PinTypes.Output, 201)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("InspSkill/Req/LevelUp", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqInspSkillLvUp : FlowNode_Network
  {
    [Token(Token = "0x400538B")]
    protected const int PIN_INPUT_REQUEST = 1;
    [Token(Token = "0x400538C")]
    protected const int PIN_OUTPUT_SUCCESS = 101;
    [Token(Token = "0x400538D")]
    protected const int PIN_OUTPUT_COSTSHORT = 201;

    [Token(Token = "0x6005E7B")]
    [Address(RVA = "0x132CBB0", Offset = "0x132B9B0", VA = "0x1132CBB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E7C")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E7D")]
    [Address(RVA = "0x132CB40", Offset = "0x132B940", VA = "0x1132CB40")]
    private void CostShort()
    {
    }

    [Token(Token = "0x6005E7E")]
    [Address(RVA = "0x132CF40", Offset = "0x132BD40", VA = "0x1132CF40", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E7F")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqInspSkillLvUp()
    {
    }
  }
}
