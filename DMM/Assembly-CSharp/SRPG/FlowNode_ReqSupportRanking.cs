// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqSupportRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001598")]
  [FlowNode.NodeType("System/Player/SupportRanking", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqSupportRanking : FlowNode_Network
  {
    [Token(Token = "0x4004E86")]
    [FieldOffset(Offset = "0x0")]
    private static string[] mUnitId;
    [Token(Token = "0x4004E87")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004E88")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x60058FE")]
    [Address(RVA = "0x12DE740", Offset = "0x12DD540", VA = "0x112DE740", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60058FF")]
    [Address(RVA = "0x12DEBF0", Offset = "0x12DD9F0", VA = "0x112DEBF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005900")]
    [Address(RVA = "0x12DE810", Offset = "0x12DD610", VA = "0x112DE810", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005901")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqSupportRanking()
    {
    }

    [Token(Token = "0x2001599")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004E89")]
      [FieldOffset(Offset = "0x28")]
      public ReqSetSupportRanking.Response body;

      [Token(Token = "0x6005902")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
