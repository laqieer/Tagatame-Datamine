// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqInspSkillAddSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001737")]
  [AddComponentMenu("")]
  [FlowNode.Pin(202, "コスト不足(COIN)", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(201, "コスト不足(GOLD)", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(203, "コスト不足(COIN_P)", FlowNode.PinTypes.Output, 203)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("InspSkill/Req/AddSlot", 32741)]
  public class FlowNode_ReqInspSkillAddSlot : FlowNode_Network
  {
    [Token(Token = "0x4005384")]
    protected const int PIN_INPUT_REQUEST = 1;
    [Token(Token = "0x4005385")]
    protected const int PIN_OUTPUT_SUCCESS = 101;
    [Token(Token = "0x4005386")]
    protected const int PIN_OUTPUT_COSTSHORT_GOLD = 201;
    [Token(Token = "0x4005387")]
    protected const int PIN_OUTPUT_COSTSHORT_COIN = 202;
    [Token(Token = "0x4005388")]
    protected const int PIN_OUTPUT_COSTSHORT_COIN_P = 203;

    [Token(Token = "0x6005E72")]
    [Address(RVA = "0x132C030", Offset = "0x132AE30", VA = "0x1132C030", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E73")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E74")]
    [Address(RVA = "0x132BF10", Offset = "0x132AD10", VA = "0x1132BF10")]
    private void CostShort()
    {
    }

    [Token(Token = "0x6005E75")]
    [Address(RVA = "0x132C1C0", Offset = "0x132AFC0", VA = "0x1132C1C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E76")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqInspSkillAddSlot()
    {
    }
  }
}
