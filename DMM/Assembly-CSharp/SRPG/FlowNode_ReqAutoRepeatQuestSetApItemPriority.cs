// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAutoRepeatQuestSetApItemPriority
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012F4")]
  [FlowNode.NodeType("AutoRepeatQuest/ReqSetApItemPriority", 32741)]
  [FlowNode.Pin(10, "AP回復アイテム優先度設定開始", FlowNode.PinTypes.Input, 10)]
  [AddComponentMenu("")]
  [FlowNode.Pin(110, "AP回復アイテム優先度設定終了", FlowNode.PinTypes.Output, 110)]
  public class FlowNode_ReqAutoRepeatQuestSetApItemPriority : FlowNode_Network
  {
    [Token(Token = "0x400467F")]
    private const int PIN_INPUT_SET_PRIORITY_START = 10;
    [Token(Token = "0x4004680")]
    private const int PIN_OUTPUT_SET_PRIORITY_END = 110;

    [Token(Token = "0x6005025")]
    [Address(RVA = "0x1253B40", Offset = "0x1252940", VA = "0x11253B40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005026")]
    [Address(RVA = "0x1253CA0", Offset = "0x1252AA0", VA = "0x11253CA0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005027")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAutoRepeatQuestSetApItemPriority()
    {
    }

    [Token(Token = "0x20012F5")]
    [MessagePackObject(true)]
    public class MP_ReqAutoRepeatQuestSetApItemPriority : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004681")]
      [FieldOffset(Offset = "0x28")]
      public ReqAutoRepeatQuestSetApItemPriority.Response body;

      [Token(Token = "0x6005028")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_ReqAutoRepeatQuestSetApItemPriority()
      {
      }
    }
  }
}
