// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRuneEnhance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001845")]
  [AddComponentMenu("")]
  [FlowNode.Pin(104, "ゼニーor幻晶石不足", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(103, "素材不足", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(102, "強化上限", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Rune/Req/Enhance", 32741)]
  public class FlowNode_ReqRuneEnhance : FlowNode_Network
  {
    [Token(Token = "0x4005713")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005714")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005715")]
    protected const int PIN_OUT_IS_UPPER_LIMIT = 102;
    [Token(Token = "0x4005716")]
    protected const int PIN_OUT_NOT_ENOUGH_MATERIAL = 103;
    [Token(Token = "0x4005717")]
    protected const int PIN_OUT_NOT_ENOUGH_CURRENCY = 104;
    [Token(Token = "0x4005718")]
    [FieldOffset(Offset = "0x0")]
    private static BindRuneData mTargetRune;
    [Token(Token = "0x4005719")]
    [FieldOffset(Offset = "0x4")]
    private static BindRuneData mBackupRune;
    [Token(Token = "0x400571A")]
    [FieldOffset(Offset = "0x8")]
    private static float mBackupGauge;
    [Token(Token = "0x400571B")]
    [FieldOffset(Offset = "0xC")]
    private static bool mIsUseEnforceGauge;
    [Token(Token = "0x400571C")]
    [FieldOffset(Offset = "0xD")]
    private static bool mIsResultSuccess;

    [Token(Token = "0x60061ED")]
    [Address(RVA = "0x1366E30", Offset = "0x1365C30", VA = "0x11366E30")]
    public static BindRuneData GetTargetRune() => (BindRuneData) null;

    [Token(Token = "0x60061EE")]
    [Address(RVA = "0x1366E00", Offset = "0x1365C00", VA = "0x11366E00")]
    public static BindRuneData GetBackupRune() => (BindRuneData) null;

    [Token(Token = "0x60061EF")]
    [Address(RVA = "0x1366DD0", Offset = "0x1365BD0", VA = "0x11366DD0")]
    public static float GetBackupGauge() => new float();

    [Token(Token = "0x60061F0")]
    [Address(RVA = "0x1366E60", Offset = "0x1365C60", VA = "0x11366E60")]
    public static bool IsResultSuccess() => new bool();

    [Token(Token = "0x60061F1")]
    [Address(RVA = "0x1366AB0", Offset = "0x13658B0", VA = "0x11366AB0")]
    public static void Clear()
    {
    }

    [Token(Token = "0x60061F2")]
    [Address(RVA = "0x13674D0", Offset = "0x13662D0", VA = "0x113674D0")]
    public static void SetTarget(BindRuneData rune_data, bool is_use_enforce_gauge)
    {
    }

    [Token(Token = "0x60061F3")]
    [Address(RVA = "0x1366B40", Offset = "0x1365940", VA = "0x11366B40")]
    public ReqRuneEnhance.RequestParam CreateReqRuneEnhance() => (ReqRuneEnhance.RequestParam) null;

    [Token(Token = "0x60061F4")]
    [Address(RVA = "0x1366E90", Offset = "0x1365C90", VA = "0x11366E90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60061F5")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x60061F6")]
    [Address(RVA = "0x1366F60", Offset = "0x1365D60", VA = "0x11366F60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60061F7")]
    [Address(RVA = "0x1367390", Offset = "0x1366190", VA = "0x11367390")]
    private void SetBackupGauge()
    {
    }

    [Token(Token = "0x60061F8")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRuneEnhance()
    {
    }

    [Token(Token = "0x2001846")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400571D")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneEnhance.Response body;

      [Token(Token = "0x60061F9")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
