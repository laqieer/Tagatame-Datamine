// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_RankMatchMissionProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001788")]
  [FlowNode.Pin(5000, "NoMatchVersion", FlowNode.PinTypes.Output, 5000)]
  [AddComponentMenu("")]
  [FlowNode.Pin(6000, "MultiMaintenance", FlowNode.PinTypes.Output, 6000)]
  [FlowNode.Pin(4802, "OutOfDate", FlowNode.PinTypes.Output, 4802)]
  [FlowNode.Pin(102, "Failure", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Get", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/API/RankMatch/MissionProgress", 32741)]
  public class FlowNode_MP_API_RankMatchMissionProgress : FlowNode_Network
  {
    [Token(Token = "0x400549B")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400549C")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400549D")]
    private const int PIN_OUT_FAILURE = 102;
    [Token(Token = "0x400549E")]
    private const int PIN_OUT_OUT_OF_DATE = 4802;
    [Token(Token = "0x400549F")]
    private const int PIN_OUT_NO_MATCH_VERSION = 5000;
    [Token(Token = "0x40054A0")]
    private const int PIN_OUT_MULTI_MAINTENANCE = 6000;

    [Token(Token = "0x6005F71")]
    [Address(RVA = "0x1335F40", Offset = "0x1334D40", VA = "0x11335F40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F72")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F73")]
    [Address(RVA = "0x1335FE0", Offset = "0x1334DE0", VA = "0x11335FE0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F74")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_RankMatchMissionProgress()
    {
    }
  }
}
