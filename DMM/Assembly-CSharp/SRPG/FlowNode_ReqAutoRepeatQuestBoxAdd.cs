// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAutoRepeatQuestBoxAdd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012EC")]
  [FlowNode.NodeType("AutoRepeatQuest/ReqBoxAdd", 32741)]
  [FlowNode.Pin(10, "BOX枠の拡張開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(110, "BOX枠の拡張終了", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(120, "幻晶石が不足", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(130, "BOX枠が上限に達している", FlowNode.PinTypes.Output, 130)]
  [AddComponentMenu("")]
  public class FlowNode_ReqAutoRepeatQuestBoxAdd : FlowNode_Network
  {
    [Token(Token = "0x400466D")]
    private const int PIN_INPUT_BOX_ADD_START = 10;
    [Token(Token = "0x400466E")]
    private const int PIN_OUTPUT_BOX_ADD_END = 110;
    [Token(Token = "0x400466F")]
    private const int PIN_OUTPUT_ERR_NOT_ENOUGH_COIN = 120;
    [Token(Token = "0x4004670")]
    private const int PIN_OUTPUT_ERR_BOX_SIZE_LIMIT = 130;

    [Token(Token = "0x600500F")]
    [Address(RVA = "0x1251E50", Offset = "0x1250C50", VA = "0x11251E50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005010")]
    [Address(RVA = "0x1251F10", Offset = "0x1250D10", VA = "0x11251F10", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005011")]
    [Address(RVA = "0x1251E00", Offset = "0x1250C00", VA = "0x11251E00")]
    private void BuyCoinSequence()
    {
    }

    [Token(Token = "0x6005012")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAutoRepeatQuestBoxAdd()
    {
    }

    [Token(Token = "0x20012ED")]
    [MessagePackObject(true)]
    public class MP_ReqAutoRepeatQuestBoxAddResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004671")]
      [FieldOffset(Offset = "0x28")]
      public ReqAutoRepeatQuestBoxAdd.Response body;

      [Token(Token = "0x6005013")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_ReqAutoRepeatQuestBoxAddResponse()
      {
      }
    }
  }
}
