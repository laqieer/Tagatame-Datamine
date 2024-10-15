// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_VersusPreparationLine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200178F")]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(301, "NoMatchVersion", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(302, "MultiMaintenance", FlowNode.PinTypes.Output, 302)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("MultiPlay/API/PvP/Versus/LINE/Preparation", 32741)]
  public class FlowNode_MP_API_VersusPreparationLine : FlowNode_Network
  {
    [Token(Token = "0x40054C9")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40054CA")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054CB")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054CC")]
    private const int PIN_OUT_NO_MATCH_VERSION = 301;
    [Token(Token = "0x40054CD")]
    private const int PIN_OUT_MULTI_MAINTENANCE = 302;

    [Token(Token = "0x6005F95")]
    [Address(RVA = "0x13482A0", Offset = "0x13470A0", VA = "0x113482A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F96")]
    [Address(RVA = "0x1348680", Offset = "0x1347480", VA = "0x11348680")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F97")]
    [Address(RVA = "0x1348380", Offset = "0x1347180", VA = "0x11348380", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F98")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_VersusPreparationLine()
    {
    }
  }
}
