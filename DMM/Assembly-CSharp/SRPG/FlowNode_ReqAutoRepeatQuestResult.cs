// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAutoRepeatQuestResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012F1")]
  [FlowNode.NodeType("AutoRepeatQuest/ReqResult", 32741)]
  [FlowNode.Pin(10, "自動周回結果の取得開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(110, "自動周回結果の取得終了", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("")]
  public class FlowNode_ReqAutoRepeatQuestResult : FlowNode_Network
  {
    [Token(Token = "0x4004679")]
    private const int PIN_INPUT_GET_RESULT_START = 10;
    [Token(Token = "0x400467A")]
    private const int PIN_OUTPUT_GET_RESULT_END = 110;

    [Token(Token = "0x600501E")]
    [Address(RVA = "0x1252F50", Offset = "0x1251D50", VA = "0x11252F50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600501F")]
    [Address(RVA = "0x1253000", Offset = "0x1251E00", VA = "0x11253000", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005020")]
    [Address(RVA = "0x1253630", Offset = "0x1252430", VA = "0x11253630")]
    private void SetupSerializeValueBehaviour(ReqAutoRepeatQuestEnd.Response response)
    {
    }

    [Token(Token = "0x6005021")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAutoRepeatQuestResult()
    {
    }

    [Token(Token = "0x20012F2")]
    [MessagePackObject(true)]
    public class MP_AutoRepeatQuestEndResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400467B")]
      [FieldOffset(Offset = "0x28")]
      public ReqAutoRepeatQuestEnd.Response body;

      [Token(Token = "0x6005022")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_AutoRepeatQuestEndResponse()
      {
      }
    }
  }
}
