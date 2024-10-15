// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRuneEvo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200184B")]
  [AddComponentMenu("")]
  [FlowNode.Pin(113, "強化回数不足", FlowNode.PinTypes.Output, 113)]
  [FlowNode.Pin(112, "覚醒上限", FlowNode.PinTypes.Output, 112)]
  [FlowNode.NodeType("Rune/Req/Evo", 32741)]
  [FlowNode.Pin(110, "素材不足", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(111, "ゼニーor幻晶石不足", FlowNode.PinTypes.Output, 111)]
  public class FlowNode_ReqRuneEvo : FlowNode_Network
  {
    [Token(Token = "0x4005726")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005727")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005728")]
    protected const int PIN_OUT_NOT_ENOUGH_MATERIAL = 110;
    [Token(Token = "0x4005729")]
    protected const int PIN_OUT_NOT_ENOUGH_CURRENCY = 111;
    [Token(Token = "0x400572A")]
    protected const int PIN_OUT_IS_UPPER_LIMIT_FOR_EVO = 112;
    [Token(Token = "0x400572B")]
    protected const int PIN_OUT_CAN_NOT_EVO_ENFORCE_SHORT = 113;
    [Token(Token = "0x400572C")]
    [FieldOffset(Offset = "0x0")]
    private static BindRuneData mTargetRune;

    [Token(Token = "0x600620B")]
    [Address(RVA = "0x1368A20", Offset = "0x1367820", VA = "0x11368A20")]
    public static BindRuneData GetTargetRune() => (BindRuneData) null;

    [Token(Token = "0x600620C")]
    [Address(RVA = "0x1368940", Offset = "0x1367740", VA = "0x11368940")]
    public static void Clear()
    {
    }

    [Token(Token = "0x600620D")]
    [Address(RVA = "0x1369000", Offset = "0x1367E00", VA = "0x11369000")]
    public static void SetTarget(BindRuneData rune_data)
    {
    }

    [Token(Token = "0x600620E")]
    [Address(RVA = "0x1368980", Offset = "0x1367780", VA = "0x11368980")]
    public ReqRuneEvo.RequestParam CreateReqRuneEvo() => (ReqRuneEvo.RequestParam) null;

    [Token(Token = "0x600620F")]
    [Address(RVA = "0x1368A50", Offset = "0x1367850", VA = "0x11368A50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006210")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006211")]
    [Address(RVA = "0x1368BB0", Offset = "0x13679B0", VA = "0x11368BB0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006212")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRuneEvo()
    {
    }

    [Token(Token = "0x200184C")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400572D")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneEvo.Response body;

      [Token(Token = "0x6006213")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
