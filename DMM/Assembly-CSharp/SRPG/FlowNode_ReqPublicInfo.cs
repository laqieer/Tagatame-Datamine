// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqPublicInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001734")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Home/ReqPublicInfo", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(111, "DuplicateFailed", FlowNode.PinTypes.Output, 111)]
  public class FlowNode_ReqPublicInfo : FlowNode_Network
  {
    [Token(Token = "0x400537C")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400537D")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400537E")]
    private const int PIN_OUT_DUPLICATION_REQUEST = 111;

    [Token(Token = "0x6005E69")]
    [Address(RVA = "0x132DA40", Offset = "0x132C840", VA = "0x1132DA40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E6A")]
    [Address(RVA = "0x132DD50", Offset = "0x132CB50", VA = "0x1132DD50")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E6B")]
    [Address(RVA = "0x132DB10", Offset = "0x132C910", VA = "0x1132DB10", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E6C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqPublicInfo()
    {
    }
  }
}
