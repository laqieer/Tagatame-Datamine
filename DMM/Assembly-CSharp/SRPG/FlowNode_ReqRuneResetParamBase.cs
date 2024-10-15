// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRuneResetParamBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001853")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(110, "素材不足", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(111, "ゼニーor幻晶石不足", FlowNode.PinTypes.Output, 111)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Rune/Req/ResetParamBase", 32741)]
  public class FlowNode_ReqRuneResetParamBase : FlowNode_Network
  {
    [Token(Token = "0x4005745")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005746")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005747")]
    protected const int PIN_OUT_NOT_ENOUGH_MATERIAL = 110;
    [Token(Token = "0x4005748")]
    protected const int PIN_OUT_NOT_ENOUGH_CURRENCY = 111;
    [Token(Token = "0x4005749")]
    [FieldOffset(Offset = "0x0")]
    private static BindRuneData mTargetRune;
    [Token(Token = "0x400574A")]
    [FieldOffset(Offset = "0x4")]
    private static BindRuneData mBackupRune;
    [Token(Token = "0x400574B")]
    [FieldOffset(Offset = "0x8")]
    private static int mCostIndex;

    [Token(Token = "0x600622C")]
    [Address(RVA = "0x136AD20", Offset = "0x1369B20", VA = "0x1136AD20")]
    public static BindRuneData GetTargetRune() => (BindRuneData) null;

    [Token(Token = "0x600622D")]
    [Address(RVA = "0x136ACF0", Offset = "0x1369AF0", VA = "0x1136ACF0")]
    public static BindRuneData GetBackupRune() => (BindRuneData) null;

    [Token(Token = "0x600622E")]
    [Address(RVA = "0x136AB60", Offset = "0x1369960", VA = "0x1136AB60")]
    public static void Clear()
    {
    }

    [Token(Token = "0x600622F")]
    [Address(RVA = "0x136B310", Offset = "0x136A110", VA = "0x1136B310")]
    public static void SetTarget(BindRuneData rune_data, int cost_index)
    {
    }

    [Token(Token = "0x6006230")]
    [Address(RVA = "0x136ABB0", Offset = "0x13699B0", VA = "0x1136ABB0")]
    public ReqRuneResetParamBase.RequestParam CreateReqRuneResetParamBase()
    {
      return (ReqRuneResetParamBase.RequestParam) null;
    }

    [Token(Token = "0x6006231")]
    [Address(RVA = "0x136AD50", Offset = "0x1369B50", VA = "0x1136AD50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006232")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006233")]
    [Address(RVA = "0x136AF40", Offset = "0x1369D40", VA = "0x1136AF40", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006234")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRuneResetParamBase()
    {
    }

    [Token(Token = "0x2001854")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400574C")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneResetParamBase.Response body;

      [Token(Token = "0x6006235")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
