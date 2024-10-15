// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_VersusIsOpenRankMatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017F1")]
  [FlowNode.Pin(1, "Is open RankMatch", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(201, "Yes", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "No", FlowNode.PinTypes.Output, 202)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("MultiPlay/RankMatch/IsOpenRankMatch", 32741)]
  public class FlowNode_MP_VersusIsOpenRankMatch : FlowNode
  {
    [Token(Token = "0x4005636")]
    private const int PIN_IN_IS_OPEN_RANKMATCH = 1;
    [Token(Token = "0x4005637")]
    private const int PIN_OUT_YES = 201;
    [Token(Token = "0x4005638")]
    private const int PIN_OUT_NO = 202;

    [Token(Token = "0x60060E0")]
    [Address(RVA = "0x135AAB0", Offset = "0x13598B0", VA = "0x1135AAB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060E1")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_VersusIsOpenRankMatch()
    {
    }
  }
}
