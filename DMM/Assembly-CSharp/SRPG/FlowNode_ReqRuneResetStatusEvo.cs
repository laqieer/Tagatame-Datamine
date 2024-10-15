// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRuneResetStatusEvo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001855")]
  [FlowNode.Pin(112, "指定した枠に覚醒効果がない", FlowNode.PinTypes.Output, 112)]
  [AddComponentMenu("")]
  [FlowNode.Pin(111, "ゼニーor幻晶石不足", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Rune/Req/ResetStatusEvo", 32741)]
  [FlowNode.Pin(110, "素材不足", FlowNode.PinTypes.Output, 110)]
  public class FlowNode_ReqRuneResetStatusEvo : FlowNode_Network
  {
    [Token(Token = "0x400574D")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400574E")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400574F")]
    protected const int PIN_OUT_NOT_ENOUGH_MATERIAL = 110;
    [Token(Token = "0x4005750")]
    protected const int PIN_OUT_NOT_ENOUGH_CURRENCY = 111;
    [Token(Token = "0x4005751")]
    protected const int PIN_OUT_NOT_FOUND_EVO_SLOT = 112;
    [Token(Token = "0x4005752")]
    [FieldOffset(Offset = "0x0")]
    private static BindRuneData mTargetRune;
    [Token(Token = "0x4005753")]
    [FieldOffset(Offset = "0x4")]
    private static int mCostIndex;
    [Token(Token = "0x4005754")]
    [FieldOffset(Offset = "0x8")]
    private static int mSelectedEvoSlot;

    [Token(Token = "0x6006236")]
    [Address(RVA = "0x136B4D0", Offset = "0x136A2D0", VA = "0x1136B4D0")]
    public static BindRuneData GetTargetRune() => (BindRuneData) null;

    [Token(Token = "0x6006237")]
    [Address(RVA = "0x136B370", Offset = "0x136A170", VA = "0x1136B370")]
    public static void Clear()
    {
    }

    [Token(Token = "0x6006238")]
    [Address(RVA = "0x136BAA0", Offset = "0x136A8A0", VA = "0x1136BAA0")]
    public static void SetTarget(BindRuneData rune_data, int cost_index, int evo_index)
    {
    }

    [Token(Token = "0x6006239")]
    [Address(RVA = "0x136B3C0", Offset = "0x136A1C0", VA = "0x1136B3C0")]
    public ReqRuneResetStatusEvo.RequestParam CreateReqRuneResetStatusEvo()
    {
      return (ReqRuneResetStatusEvo.RequestParam) null;
    }

    [Token(Token = "0x600623A")]
    [Address(RVA = "0x136B500", Offset = "0x136A300", VA = "0x1136B500", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600623B")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x600623C")]
    [Address(RVA = "0x136B6C0", Offset = "0x136A4C0", VA = "0x1136B6C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600623D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRuneResetStatusEvo()
    {
    }

    [Token(Token = "0x2001856")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005755")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneResetStatusEvo.Response body;

      [Token(Token = "0x600623E")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
