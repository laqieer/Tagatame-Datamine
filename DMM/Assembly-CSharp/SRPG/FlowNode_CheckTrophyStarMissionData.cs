// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckTrophyStarMissionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001875")]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(111, "Exist", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(112, "NotExist", FlowNode.PinTypes.Output, 112)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Trophy/StarMission/Check/Data", 32741)]
  public class FlowNode_CheckTrophyStarMissionData : FlowNode
  {
    [Token(Token = "0x40057B9")]
    private const int PIN_IN_CHECK = 1;
    [Token(Token = "0x40057BA")]
    private const int PIN_OUT_EXIST = 111;
    [Token(Token = "0x40057BB")]
    private const int PIN_OUT_NOT_EXIST = 112;

    [Token(Token = "0x6006290")]
    [Address(RVA = "0x3062D0", Offset = "0x3050D0", VA = "0x103062D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006291")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckTrophyStarMissionData()
    {
    }
  }
}
