// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAutoRepeatQuestBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012EA")]
  [FlowNode.NodeType("AutoRepeatQuest/ReqBox", 32741)]
  [FlowNode.Pin(110, "BOX枠の拡張回数取得終了", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "BOX枠の拡張回数取得", FlowNode.PinTypes.Input, 10)]
  public class FlowNode_ReqAutoRepeatQuestBox : FlowNode_Network
  {
    [Token(Token = "0x4004669")]
    private const int PIN_INPUT_START = 10;
    [Token(Token = "0x400466A")]
    private const int PIN_OUTPUT_END = 110;
    [Token(Token = "0x400466B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool mRequestForce;

    [Token(Token = "0x600500B")]
    [Address(RVA = "0x1252290", Offset = "0x1251090", VA = "0x11252290", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600500C")]
    [Address(RVA = "0x12523E0", Offset = "0x12511E0", VA = "0x112523E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600500D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAutoRepeatQuestBox()
    {
    }

    [Token(Token = "0x20012EB")]
    [MessagePackObject(true)]
    public class MP_ReqAutoRepeatQuestBoxResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400466C")]
      [FieldOffset(Offset = "0x28")]
      public ReqAutoRepeatQuestBox.Response body;

      [Token(Token = "0x600500E")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_ReqAutoRepeatQuestBoxResponse()
      {
      }
    }
  }
}
