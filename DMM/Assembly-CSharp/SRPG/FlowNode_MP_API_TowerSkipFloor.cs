// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_TowerSkipFloor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001796")]
  [FlowNode.NodeType("MultiPlay/API/Tower/SkipFloor", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(304, "Out of Date", FlowNode.PinTypes.Output, 304)]
  [FlowNode.Pin(302, "No Match Version", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(301, "Not Exist Floor", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(303, "Can not Skip Floor", FlowNode.PinTypes.Output, 303)]
  public class FlowNode_MP_API_TowerSkipFloor : FlowNode_Network
  {
    [Token(Token = "0x40054FB")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40054FC")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054FD")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054FE")]
    private const int PIN_OUT_NOT_EXIST_FLOOR = 301;
    [Token(Token = "0x40054FF")]
    private const int PIN_OUT_NO_MATCH_VERSION = 302;
    [Token(Token = "0x4005500")]
    private const int PIN_OUT_CANNOT_SKIP_FLOOR = 303;
    [Token(Token = "0x4005501")]
    private const int PIN_OUT_OUT_OF_DATE_QUEST = 304;

    [Token(Token = "0x6005FB8")]
    [Address(RVA = "0x1347820", Offset = "0x1346620", VA = "0x11347820", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FB9")]
    [Address(RVA = "0x1347990", Offset = "0x1346790", VA = "0x11347990", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005FBA")]
    [Address(RVA = "0x1347D70", Offset = "0x1346B70", VA = "0x11347D70")]
    private void Success()
    {
    }

    [Token(Token = "0x6005FBB")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_TowerSkipFloor()
    {
    }
  }
}
