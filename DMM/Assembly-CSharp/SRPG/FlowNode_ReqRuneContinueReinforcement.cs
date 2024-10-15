// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRuneContinueReinforcement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001841")]
  [FlowNode.Pin(106, "覚醒上限", FlowNode.PinTypes.Output, 106)]
  [FlowNode.Pin(104, "ゼニーor幻晶石不足", FlowNode.PinTypes.Output, 104)]
  [FlowNode.NodeType("Rune/Req/ContinueReinforcement", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(105, "ルーン非所持", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(102, "強化上限", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(107, "強化/覚醒数の指定が異常", FlowNode.PinTypes.Output, 107)]
  [AddComponentMenu("")]
  [FlowNode.Pin(103, "素材不足", FlowNode.PinTypes.Output, 103)]
  public class FlowNode_ReqRuneContinueReinforcement : FlowNode_Network
  {
    [Token(Token = "0x40056F6")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40056F7")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40056F8")]
    protected const int PIN_OUT_IS_UPPER_LIMIT = 102;
    [Token(Token = "0x40056F9")]
    protected const int PIN_OUT_NOT_ENOUGH_MATERIAL = 103;
    [Token(Token = "0x40056FA")]
    protected const int PIN_OUT_NOT_ENOUGH_CURRENCY = 104;
    [Token(Token = "0x40056FB")]
    protected const int PIN_OUT_NON_POSSESSION = 105;
    [Token(Token = "0x40056FC")]
    protected const int PIN_OUT_IS_UPPER_LIMIT_EVO = 106;
    [Token(Token = "0x40056FD")]
    protected const int PIN_OUT_LEVEL_OUT_OF_RANGE = 107;
    [Token(Token = "0x40056FE")]
    public const string KEY_RUNE_CONTINUE_REINFORCEMENT_RUNE = "Rune";
    [Token(Token = "0x40056FF")]
    public const string KEY_RUNE_CONTINUE_REINFORCEMENT_BEFORE_RUNE = "BeforeRune";
    [Token(Token = "0x4005700")]
    public const string KEY_RUNE_CONTINUE_REINFORCEMENT_AFTER_RUNE = "AfterRune";
    [Token(Token = "0x4005701")]
    public const string KEY_RUNE_CONTINUE_REINFORCEMENT_ENHANCE_LEVEL = "RuneEnforceLevel";
    [Token(Token = "0x4005702")]
    public const string KEY_RUNE_CONTINUE_REINFORCEMENT_EVO_LEVEL = "RuneEvoLevel";
    [Token(Token = "0x4005703")]
    public const string KEY_RUNE_CONTINUE_REINFORCEMENT_RUNE_MANAGER = "RuneManager";
    [Token(Token = "0x4005704")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour svb;
    [Token(Token = "0x4005705")]
    [FieldOffset(Offset = "0x24")]
    private BindRuneData mBaseRune;
    [Token(Token = "0x4005706")]
    [FieldOffset(Offset = "0x28")]
    private BindRuneData mBackupRune;
    [Token(Token = "0x4005707")]
    [FieldOffset(Offset = "0x2C")]
    private SerializeValueList mSVL;
    [Token(Token = "0x4005708")]
    [FieldOffset(Offset = "0x30")]
    private int mEnhanceLevel;
    [Token(Token = "0x4005709")]
    [FieldOffset(Offset = "0x34")]
    private int mEvoLevel;

    [Token(Token = "0x60061D7")]
    [Address(RVA = "0x1364A00", Offset = "0x1363800", VA = "0x11364A00")]
    public ReqRuneContinueReinforcement.RequestParam CreateReqRuneContinueReinforcement(
      BindRuneData bindRune,
      int enforce_Level,
      int evo_Level)
    {
      return (ReqRuneContinueReinforcement.RequestParam) null;
    }

    [Token(Token = "0x60061D8")]
    [Address(RVA = "0x1364B20", Offset = "0x1363920", VA = "0x11364B20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60061D9")]
    [Address(RVA = "0x1364BA0", Offset = "0x13639A0", VA = "0x11364BA0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60061DA")]
    [Address(RVA = "0x13654F0", Offset = "0x13642F0", VA = "0x113654F0")]
    private void Success()
    {
    }

    [Token(Token = "0x60061DB")]
    [Address(RVA = "0x1364E70", Offset = "0x1363C70", VA = "0x11364E70", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60061DC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRuneContinueReinforcement()
    {
    }

    [Token(Token = "0x2001842")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400570A")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneContinueReinforcement.Response body;

      [Token(Token = "0x60061E2")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
