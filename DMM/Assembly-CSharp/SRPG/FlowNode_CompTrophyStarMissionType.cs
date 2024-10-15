// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CompTrophyStarMissionType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001876")]
  [FlowNode.Pin(102, "Not Equal", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Comp", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Trophy/StarMission/Comp/Type", 32741)]
  [FlowNode.Pin(101, "Equal", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_CompTrophyStarMissionType : FlowNode
  {
    [Token(Token = "0x40057BC")]
    private const int PIN_IN_COMP = 1;
    [Token(Token = "0x40057BD")]
    private const int PIN_OUT_EQUAL = 101;
    [Token(Token = "0x40057BE")]
    private const int PIN_OUT_NOT_EQUAL = 102;
    [Token(Token = "0x40057BF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TrophyStarMissionParam.eStarMissionType Type;

    [Token(Token = "0x6006292")]
    [Address(RVA = "0x306B60", Offset = "0x305960", VA = "0x10306B60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006293")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CompTrophyStarMissionType()
    {
    }
  }
}
