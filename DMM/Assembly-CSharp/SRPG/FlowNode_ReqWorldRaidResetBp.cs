// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqWorldRaidResetBp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018B3")]
  [FlowNode.NodeType("WorldRaid/Req/WorldRaidResetBp", 32741)]
  [FlowNode.Pin(1, "リクエスト", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "成功", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "期間外", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "BP上限", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(203, "BP変動", FlowNode.PinTypes.Output, 203)]
  public class FlowNode_ReqWorldRaidResetBp : FlowNode_Network
  {
    [Token(Token = "0x4005895")]
    private const int PIN_INPUT_REQ = 1;
    [Token(Token = "0x4005896")]
    private const int PIN_OUTPUT_SUCCESS = 101;
    [Token(Token = "0x4005897")]
    private const int PIN_OUTPUT_FAILED_OUTOFPERIOD = 201;
    [Token(Token = "0x4005898")]
    private const int PIN_OUTPUT_FAILED_LIMIT_BP = 202;
    [Token(Token = "0x4005899")]
    private const int PIN_OUTPUT_FAILED_CHANGE_BP = 203;

    [Token(Token = "0x600634F")]
    [Address(RVA = "0x3145D0", Offset = "0x3133D0", VA = "0x103145D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006350")]
    [Address(RVA = "0x314C80", Offset = "0x313A80", VA = "0x10314C80")]
    private void Success()
    {
    }

    [Token(Token = "0x6006351")]
    [Address(RVA = "0x314730", Offset = "0x313530", VA = "0x10314730", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006352")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqWorldRaidResetBp()
    {
    }

    [Token(Token = "0x20018B4")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400589A")]
      [FieldOffset(Offset = "0x28")]
      public ReqWorldRaidResetBattlePoint.Response body;

      [Token(Token = "0x6006356")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
