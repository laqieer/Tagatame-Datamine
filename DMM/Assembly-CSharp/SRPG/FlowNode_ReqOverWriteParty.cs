// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqOverWriteParty
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
  [Token(Token = "0x2001556")]
  [FlowNode.Pin(1, "取得開始", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/Party/ReqOverWriteParty", 32741)]
  [FlowNode.Pin(101, "取得完了", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqOverWriteParty : FlowNode_Network
  {
    [Token(Token = "0x4004DDF")]
    private const int PIN_INPUT_START = 1;
    [Token(Token = "0x4004DE0")]
    private const int PIN_OUTPUT_END = 101;
    [Token(Token = "0x4004DE1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [BitMask]
    private FlowNode_ReqOverWriteParty.ExecConditions mExecConditions;

    [Token(Token = "0x600582D")]
    [Address(RVA = "0x12D6360", Offset = "0x12D5160", VA = "0x112D6360", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600582E")]
    [Address(RVA = "0x12D62F0", Offset = "0x12D50F0", VA = "0x112D62F0")]
    private bool CheckConditions() => new bool();

    [Token(Token = "0x600582F")]
    [Address(RVA = "0x12D6490", Offset = "0x12D5290", VA = "0x112D6490", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005830")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqOverWriteParty()
    {
    }

    [Token(Token = "0x2001557")]
    [Flags]
    public enum ExecConditions
    {
      [Token(Token = "0x4004DE3")] ResumeBattle = 1,
    }

    [Token(Token = "0x2001558")]
    [MessagePackObject(true)]
    public class MP_OverWritePartyResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004DE4")]
      [FieldOffset(Offset = "0x28")]
      public ReqOverWriteParty.Response body;

      [Token(Token = "0x6005831")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_OverWritePartyResponse()
      {
      }
    }
  }
}
