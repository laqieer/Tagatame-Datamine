// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRuneParamEnhEvo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200184F")]
  [FlowNode.Pin(104, "指定した枠に覚醒効果がない", FlowNode.PinTypes.Output, 104)]
  [AddComponentMenu("")]
  [FlowNode.Pin(104, "リクエスト作成失敗", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(102, "素材不足", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Rune/Req/RuneParamEnhEvo", 32741)]
  [FlowNode.Pin(103, "ゼニーor幻晶石不足", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqRuneParamEnhEvo : FlowNode_Network
  {
    [Token(Token = "0x4005735")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005736")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005737")]
    protected const int PIN_OUT_NOT_ENOUGH_MATERIAL = 102;
    [Token(Token = "0x4005738")]
    protected const int PIN_OUT_NOT_ENOUGH_CURRENCY = 103;
    [Token(Token = "0x4005739")]
    protected const int PIN_OUT_NOT_FOUND_EVO_SLOT = 104;
    [Token(Token = "0x400573A")]
    protected const int PIN_OUT_NULL_REQUEST = 110;
    [Token(Token = "0x400573B")]
    [FieldOffset(Offset = "0x0")]
    private static BindRuneData mTargetRune;
    [Token(Token = "0x400573C")]
    [FieldOffset(Offset = "0x4")]
    private static BindRuneData mBackupRune;
    [Token(Token = "0x400573D")]
    [FieldOffset(Offset = "0x8")]
    private static int mSelectedEvoSlot;
    [Token(Token = "0x400573E")]
    [FieldOffset(Offset = "0xC")]
    private static int mSelectedEvoIndex;
    [Token(Token = "0x400573F")]
    [FieldOffset(Offset = "0x10")]
    private static int mCostIndex;
    [Token(Token = "0x4005740")]
    [FieldOffset(Offset = "0x14")]
    private static bool mIsResultSuccess;

    [Token(Token = "0x170009BF")]
    public static BindRuneData TargetRune
    {
      [Token(Token = "0x600621A"), Address(RVA = "0x1369E70", Offset = "0x1368C70", VA = "0x11369E70")] get
      {
        return (BindRuneData) null;
      }
    }

    [Token(Token = "0x170009C0")]
    public static BindRuneData BackupRune
    {
      [Token(Token = "0x600621B"), Address(RVA = "0x1369DB0", Offset = "0x1368BB0", VA = "0x11369DB0")] get
      {
        return (BindRuneData) null;
      }
    }

    [Token(Token = "0x170009C1")]
    public static bool IsResultSuccess
    {
      [Token(Token = "0x600621C"), Address(RVA = "0x1369DE0", Offset = "0x1368BE0", VA = "0x11369DE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170009C2")]
    public static int SelectedEvoSlot
    {
      [Token(Token = "0x600621D"), Address(RVA = "0x1369E40", Offset = "0x1368C40", VA = "0x11369E40")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170009C3")]
    public static int SelectedEvoIndex
    {
      [Token(Token = "0x600621E"), Address(RVA = "0x1369E10", Offset = "0x1368C10", VA = "0x11369E10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600621F")]
    [Address(RVA = "0x1369550", Offset = "0x1368350", VA = "0x11369550")]
    public static void Clear()
    {
    }

    [Token(Token = "0x6006220")]
    [Address(RVA = "0x1369D20", Offset = "0x1368B20", VA = "0x11369D20")]
    public static void SetTarget(BindRuneData rune_data, int cost_index, int evo_index)
    {
    }

    [Token(Token = "0x6006221")]
    [Address(RVA = "0x13695F0", Offset = "0x13683F0", VA = "0x113695F0")]
    public ReqRuneParamEnhEvo.RequestParam CreateReqRuneParamEnhEvo()
    {
      return (ReqRuneParamEnhEvo.RequestParam) null;
    }

    [Token(Token = "0x6006222")]
    [Address(RVA = "0x1369740", Offset = "0x1368540", VA = "0x11369740", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006223")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    public void Success()
    {
    }

    [Token(Token = "0x6006224")]
    [Address(RVA = "0x1369930", Offset = "0x1368730", VA = "0x11369930", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006225")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRuneParamEnhEvo()
    {
    }

    [Token(Token = "0x2001850")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005741")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneParamEnhEvo.Response body;

      [Token(Token = "0x6006226")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
