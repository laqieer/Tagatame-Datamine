// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTobiraFullMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015A1")]
  [AddComponentMenu("")]
  [FlowNode.Pin(110, "ホームに戻すべきエラー", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(101, "一括強化:Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("System/Unit/ReqTobira/ReqTobiraFullMaster")]
  [FlowNode.Pin(1, "一括強化:Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqTobiraFullMaster : FlowNode_Network
  {
    [Token(Token = "0x4004E98")]
    public const int PIN_INPUT_REQUEST = 1;
    [Token(Token = "0x4004E99")]
    public const int PIN_OUTPUT_REQUEST = 101;
    [Token(Token = "0x4004E9A")]
    public const int PIN_OUTPUT_ERROR_GO_HOME = 110;

    [Token(Token = "0x600591D")]
    [Address(RVA = "0x12DF730", Offset = "0x12DE530", VA = "0x112DF730", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600591E")]
    [Address(RVA = "0x12DF880", Offset = "0x12DE680", VA = "0x112DF880", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600591F")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTobiraFullMaster()
    {
    }

    [Token(Token = "0x20015A2")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004E9B")]
      [FieldOffset(Offset = "0x28")]
      public ReqTobiraFullMaster.Response body;

      [Token(Token = "0x6005921")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
