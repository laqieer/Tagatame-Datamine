// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_RankMatchMakeRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001787")]
  [AddComponentMenu("")]
  [FlowNode.Pin(304, "No Match Version", FlowNode.PinTypes.Output, 304)]
  [FlowNode.Pin(303, "Out of Period", FlowNode.PinTypes.Output, 303)]
  [FlowNode.Pin(302, "Out of Date", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(301, "Failed Make Room", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(305, "Maintenance", FlowNode.PinTypes.Output, 305)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Make Room", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/API/RankMatch/MakeRoom", 32741)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  public class FlowNode_MP_API_RankMatchMakeRoom : FlowNode_Network
  {
    [Token(Token = "0x4005493")]
    private const int PIN_IN_MAKE_ROOM = 1;
    [Token(Token = "0x4005494")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005495")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x4005496")]
    private const int PIN_OUT_FAILED_MAKE_ROOM = 301;
    [Token(Token = "0x4005497")]
    private const int PIN_OUT_OUT_OF_DATE_QUEST = 302;
    [Token(Token = "0x4005498")]
    private const int PIN_OUT_OUT_OF_PERIOD = 303;
    [Token(Token = "0x4005499")]
    private const int PIN_OUT_NO_MATCH_VERSION = 304;
    [Token(Token = "0x400549A")]
    private const int PIN_OUT_MAINTENANCE = 305;

    [Token(Token = "0x6005F6C")]
    [Address(RVA = "0x1335860", Offset = "0x1334660", VA = "0x11335860", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F6D")]
    [Address(RVA = "0x1335900", Offset = "0x1334700", VA = "0x11335900", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F6E")]
    [Address(RVA = "0x1335ED0", Offset = "0x1334CD0", VA = "0x11335ED0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F6F")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_RankMatchMakeRoom()
    {
    }
  }
}
