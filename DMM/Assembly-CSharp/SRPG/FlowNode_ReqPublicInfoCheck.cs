// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqPublicInfoCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001735")]
  [FlowNode.Pin(111, "DuplicateFailed", FlowNode.PinTypes.Output, 111)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Home/ReqPublicInfoCheck", 32741)]
  public class FlowNode_ReqPublicInfoCheck : FlowNode_Network
  {
    [Token(Token = "0x400537F")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005380")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005381")]
    private const int PIN_OUT_DUPLICATION_REQUEST = 111;
    [Token(Token = "0x4005382")]
    [FieldOffset(Offset = "0x20")]
    public bool IsUseCoolTime;

    [Token(Token = "0x6005E6D")]
    [Address(RVA = "0x132D3D0", Offset = "0x132C1D0", VA = "0x1132D3D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E6E")]
    [Address(RVA = "0x132D9D0", Offset = "0x132C7D0", VA = "0x1132D9D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E6F")]
    [Address(RVA = "0x132D5D0", Offset = "0x132C3D0", VA = "0x1132D5D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E70")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqPublicInfoCheck()
    {
    }

    [Token(Token = "0x2001736")]
    [MessagePackObject(true)]
    public class PublicInfoCheckResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005383")]
      [FieldOffset(Offset = "0x28")]
      public ReqPublicInfoCheck.Response body;

      [Token(Token = "0x6005E71")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public PublicInfoCheckResponse()
      {
      }
    }
  }
}
