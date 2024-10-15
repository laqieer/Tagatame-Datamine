// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_PvPLobby
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001786")]
  [FlowNode.NodeType("MultiPlay/API/PvP/Lobby", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(301, "NoMatchVersion", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(302, "MultiMaintenance", FlowNode.PinTypes.Output, 302)]
  [AddComponentMenu("")]
  public class FlowNode_MP_API_PvPLobby : FlowNode_Network
  {
    [Token(Token = "0x400548B")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400548C")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400548D")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x400548E")]
    private const int PIN_OUT_NO_MATCH_VERSION = 301;
    [Token(Token = "0x400548F")]
    private const int PIN_OUT_MULTI_MAINTENANCE = 302;
    [Token(Token = "0x4005490")]
    public const string KEY_REQ_LEAGUEMATCH_ID = "KEY_REQ_LEAGUEMATCH_ID";
    [Token(Token = "0x4005491")]
    public const string KEY_REQ_LEAGUEMATCH_MATCHING_PERIOD = "KEY_REQ_LEAGUEMATCH_MATCHING_PERIOD";
    [Token(Token = "0x4005492")]
    public const int LEAGUEMATCH_MATCHING = 1;

    [Token(Token = "0x6005F67")]
    [Address(RVA = "0x1335160", Offset = "0x1333F60", VA = "0x11335160", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F68")]
    [Address(RVA = "0x13357E0", Offset = "0x13345E0", VA = "0x113357E0")]
    private void Success(SerializeValueList _valueList = null)
    {
    }

    [Token(Token = "0x6005F69")]
    [Address(RVA = "0x1335210", Offset = "0x1334010", VA = "0x11335210", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F6A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_PvPLobby()
    {
    }
  }
}
