// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_TowerStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001797")]
  [FlowNode.NodeType("MultiPlay/API/Tower/Status", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [AddComponentMenu("")]
  [FlowNode.Pin(302, "Out of Date", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(301, "No Match Version", FlowNode.PinTypes.Output, 301)]
  public class FlowNode_MP_API_TowerStatus : FlowNode_Network
  {
    [Token(Token = "0x4005502")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005503")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005504")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x4005505")]
    private const int PIN_OUT_NO_MATCH_VERSION = 301;
    [Token(Token = "0x4005506")]
    private const int PIN_OUT_OUT_OF_DATE_QUEST = 302;

    [Token(Token = "0x6005FBC")]
    [Address(RVA = "0x1347E00", Offset = "0x1346C00", VA = "0x11347E00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FBD")]
    [Address(RVA = "0x1347EE0", Offset = "0x1346CE0", VA = "0x11347EE0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005FBE")]
    [Address(RVA = "0x1348210", Offset = "0x1347010", VA = "0x11348210")]
    private void Success()
    {
    }

    [Token(Token = "0x6005FBF")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_TowerStatus()
    {
    }
  }
}
