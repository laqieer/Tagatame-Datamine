// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsRemainResultInspirationSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012F9")]
  [FlowNode.Pin(11, "まだひらめき演出があるか？(継続)", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(111, "ある", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(112, "ない", FlowNode.PinTypes.Output, 112)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "ひらめき演出があるか？(初期化)", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Battle/IsRemainResultInspirationSkill", 4513092)]
  public class FlowNode_IsRemainResultInspirationSkill : FlowNode
  {
    [Token(Token = "0x400468A")]
    private const int PIN_IN_IS_EXIST = 1;
    [Token(Token = "0x400468B")]
    private const int PIN_IN_IS_NEXT = 11;
    [Token(Token = "0x400468C")]
    private const int PIN_OUT_YES = 111;
    [Token(Token = "0x400468D")]
    private const int PIN_OUT_NO = 112;

    [Token(Token = "0x6005031")]
    [Address(RVA = "0x124FEF0", Offset = "0x124ECF0", VA = "0x1124FEF0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005032")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsRemainResultInspirationSkill()
    {
    }
  }
}
