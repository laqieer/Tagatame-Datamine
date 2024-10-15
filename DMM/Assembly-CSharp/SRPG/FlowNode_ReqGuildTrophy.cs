// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildTrophy
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
  [Token(Token = "0x2001878")]
  [FlowNode.Pin(1001, "ポート未所属", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1000, "Cancel", FlowNode.PinTypes.Output, 1000)]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "RequestSpan", FlowNode.PinTypes.Input, 2)]
  [FlowNode.NodeType("GuildTrophy/Req/ReqGuildTrophy", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGuildTrophy : FlowNode_Network
  {
    [Token(Token = "0x40057C5")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40057C6")]
    protected const int PIN_IN_REQUEST_SPAN = 2;
    [Token(Token = "0x40057C7")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40057C8")]
    protected const int PIN_OUT_CANCEL = 1000;
    [Token(Token = "0x40057C9")]
    protected const int PIN_OUT_NOT_JOINED = 1001;
    [Token(Token = "0x40057CA")]
    [FieldOffset(Offset = "0x0")]
    private static FlowNode_ReqGuildTrophy.AfterCertainPeriodTime mAfterCertainPeriodTime;

    [Token(Token = "0x6006296")]
    [Address(RVA = "0x309610", Offset = "0x308410", VA = "0x10309610")]
    public static void ResetTimer()
    {
    }

    [Token(Token = "0x6006297")]
    [Address(RVA = "0x308EF0", Offset = "0x307CF0", VA = "0x10308EF0")]
    public ReqGuildTrophy.RequestParam CreateReqGetGuildTrophy()
    {
      return (ReqGuildTrophy.RequestParam) null;
    }

    [Token(Token = "0x6006298")]
    [Address(RVA = "0x308F40", Offset = "0x307D40", VA = "0x10308F40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006299")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x600629A")]
    [Address(RVA = "0x3091E0", Offset = "0x307FE0", VA = "0x103091E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600629B")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildTrophy()
    {
    }

    [Token(Token = "0x600629C")]
    [Address(RVA = "0x3096C0", Offset = "0x3084C0", VA = "0x103096C0")]
    static FlowNode_ReqGuildTrophy()
    {
    }

    [Token(Token = "0x2001879")]
    public class AfterCertainPeriodTime
    {
      [Token(Token = "0x40057CB")]
      [FieldOffset(Offset = "0x8")]
      private DateTime mDateTime;
      [Token(Token = "0x40057CC")]
      private const int PERIOD_TIME = 1;

      [Token(Token = "0x600629E")]
      [Address(RVA = "0x305C60", Offset = "0x304A60", VA = "0x10305C60")]
      public void Clear()
      {
      }

      [Token(Token = "0x600629F")]
      [Address(RVA = "0x305D50", Offset = "0x304B50", VA = "0x10305D50")]
      public void TimeUpdate()
      {
      }

      [Token(Token = "0x60062A0")]
      [Address(RVA = "0x305CB0", Offset = "0x304AB0", VA = "0x10305CB0")]
      public bool IsAfterCertainPeriodTime() => new bool();

      [Token(Token = "0x60062A1")]
      [Address(RVA = "0x305DA0", Offset = "0x304BA0", VA = "0x10305DA0")]
      public AfterCertainPeriodTime()
      {
      }
    }

    [Token(Token = "0x200187A")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40057CD")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildTrophy.Response body;

      [Token(Token = "0x60062A2")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
