// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetTrophyStarMissionType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001886")]
  [FlowNode.Pin(1, "Set Daily", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Set Weekly", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(101, "Done", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Trophy/StarMission/Set/Type", 32741)]
  public class FlowNode_SetTrophyStarMissionType : FlowNode
  {
    [Token(Token = "0x40057F2")]
    private const int PIN_IN_SET_DAILY = 1;
    [Token(Token = "0x40057F3")]
    private const int PIN_IN_SET_WEEKLY = 2;
    [Token(Token = "0x40057F4")]
    private const int PIN_OUT_DONE = 101;

    [Token(Token = "0x60062CD")]
    [Address(RVA = "0x315C40", Offset = "0x314A40", VA = "0x10315C40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60062CE")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetTrophyStarMissionType()
    {
    }
  }
}
