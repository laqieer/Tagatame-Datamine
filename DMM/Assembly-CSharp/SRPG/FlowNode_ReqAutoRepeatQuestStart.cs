// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAutoRepeatQuestStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012F6")]
  [FlowNode.Pin(120, "Failure(自動周回開始)", FlowNode.PinTypes.Output, 120)]
  [FlowNode.NodeType("AutoRepeatQuest/ReqStart", 32741)]
  [FlowNode.Pin(110, "Success(自動周回開始)", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "Request(自動周回開始)", FlowNode.PinTypes.Input, 10)]
  public class FlowNode_ReqAutoRepeatQuestStart : FlowNode_Network
  {
    [Token(Token = "0x4004682")]
    private const int PIN_INPUT_REQUEST = 10;
    [Token(Token = "0x4004683")]
    private const int PIN_OUTPUT_SUCCESS = 110;
    [Token(Token = "0x4004684")]
    private const int PIN_OUTPUT_FAILURE = 120;
    [Token(Token = "0x4004685")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AutoRepeatQuestStart Target;

    [Token(Token = "0x6005029")]
    [Address(RVA = "0x1253E90", Offset = "0x1252C90", VA = "0x11253E90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600502A")]
    [Address(RVA = "0x12543F0", Offset = "0x12531F0", VA = "0x112543F0")]
    private void Request()
    {
    }

    [Token(Token = "0x600502B")]
    [Address(RVA = "0x1252A70", Offset = "0x1251870", VA = "0x11252A70")]
    private void Success()
    {
    }

    [Token(Token = "0x600502C")]
    [Address(RVA = "0x1253EC0", Offset = "0x1252CC0", VA = "0x11253EC0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600502D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAutoRepeatQuestStart()
    {
    }

    [Token(Token = "0x20012F7")]
    [MessagePackObject(true)]
    public class MP_AutoRepeatQuestStartResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004686")]
      [FieldOffset(Offset = "0x28")]
      public ReqAutoRepeatQuestStart.Response body;

      [Token(Token = "0x600502E")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_AutoRepeatQuestStartResponse()
      {
      }
    }
  }
}
