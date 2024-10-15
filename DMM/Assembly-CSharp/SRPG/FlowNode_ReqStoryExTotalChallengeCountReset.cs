// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqStoryExTotalChallengeCountReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001815")]
  [AddComponentMenu("")]
  [FlowNode.Pin(110, "トータル挑戦回数リセット終了", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(10, "トータル挑戦回数リセット開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("StoryExTotalChallengeCount/Reset", 32741)]
  [FlowNode.Pin(120, "幻晶石が不足", FlowNode.PinTypes.Output, 120)]
  public class FlowNode_ReqStoryExTotalChallengeCountReset : FlowNode_Network
  {
    [Token(Token = "0x40056A3")]
    private const int PIN_INPUT_START = 10;
    [Token(Token = "0x40056A4")]
    private const int PIN_OUTPUT_END = 110;
    [Token(Token = "0x40056A5")]
    private const int PIN_OUTPUT_ERR_NOT_ENOUGH_COIN = 120;
    [Token(Token = "0x40056A6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private eResetCostType mCostType;

    [Token(Token = "0x6006145")]
    [Address(RVA = "0x136D090", Offset = "0x136BE90", VA = "0x1136D090", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006146")]
    [Address(RVA = "0x136D160", Offset = "0x136BF60", VA = "0x1136D160", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006147")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqStoryExTotalChallengeCountReset()
    {
    }

    [Token(Token = "0x2001816")]
    [MessagePackObject(true)]
    public class MP_ReqStoryExChallengeCountResetResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40056A7")]
      [FieldOffset(Offset = "0x28")]
      public ReqStoryExChallengeCountReset.Response body;

      [Token(Token = "0x6006148")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_ReqStoryExChallengeCountResetResponse()
      {
      }
    }
  }
}
