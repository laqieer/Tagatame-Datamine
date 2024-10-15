// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRuneDisassembly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001843")]
  [FlowNode.Pin(110, "装備中含む", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Rune/Req/Disassembly", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(112, "お気に入り含む", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(111, "ゼニーor幻晶石不足", FlowNode.PinTypes.Output, 111)]
  public class FlowNode_ReqRuneDisassembly : FlowNode_Network
  {
    [Token(Token = "0x400570B")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400570C")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400570D")]
    protected const int PIN_OUT_INCLUDES_EQUIPPED_RUNES = 110;
    [Token(Token = "0x400570E")]
    protected const int PIN_OUT_NOT_ENOUGH_CURRENCY = 111;
    [Token(Token = "0x400570F")]
    protected const int PIN_OUT_IS_FAVORITE = 112;
    [Token(Token = "0x4005710")]
    [FieldOffset(Offset = "0x0")]
    private static List<BindRuneData> mTargetRunes;
    [Token(Token = "0x4005711")]
    [FieldOffset(Offset = "0x4")]
    private static ReqRuneDisassembly.Response mKeepResponse;

    [Token(Token = "0x60061E3")]
    [Address(RVA = "0x13661D0", Offset = "0x1364FD0", VA = "0x113661D0")]
    public static List<BindRuneData> GetTargetRunes() => (List<BindRuneData>) null;

    [Token(Token = "0x60061E4")]
    [Address(RVA = "0x13661A0", Offset = "0x1364FA0", VA = "0x113661A0")]
    public static ReqRuneDisassembly.Response GetResponse() => (ReqRuneDisassembly.Response) null;

    [Token(Token = "0x60061E5")]
    [Address(RVA = "0x1365ED0", Offset = "0x1364CD0", VA = "0x11365ED0")]
    public static void Clear()
    {
    }

    [Token(Token = "0x60061E6")]
    [Address(RVA = "0x1366900", Offset = "0x1365700", VA = "0x11366900")]
    public static void SetTarget(List<BindRuneData> runes)
    {
    }

    [Token(Token = "0x60061E7")]
    [Address(RVA = "0x1365F10", Offset = "0x1364D10", VA = "0x11365F10")]
    public ReqRuneDisassembly.RequestParam CreateReqRuneDisassembly()
    {
      return (ReqRuneDisassembly.RequestParam) null;
    }

    [Token(Token = "0x60061E8")]
    [Address(RVA = "0x1366200", Offset = "0x1365000", VA = "0x11366200", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60061E9")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x60061EA")]
    [Address(RVA = "0x13662D0", Offset = "0x13650D0", VA = "0x113662D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60061EB")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRuneDisassembly()
    {
    }

    [Token(Token = "0x2001844")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005712")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneDisassembly.Response body;

      [Token(Token = "0x60061EC")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
