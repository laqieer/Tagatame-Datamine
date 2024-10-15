// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLoginPack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001767")]
  [FlowNode.NodeType("System/Login/ReqLoginPack", 32741)]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_ReqLoginPack : FlowNode_Network
  {
    [Token(Token = "0x6005EFF")]
    [Address(RVA = "0x1342BD0", Offset = "0x13419D0", VA = "0x11342BD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F00")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F01")]
    [Address(RVA = "0x13433E0", Offset = "0x13421E0", VA = "0x113433E0")]
    private void reflectTrophyProgs(JSON_TrophyProgress[] trophy_progs)
    {
    }

    [Token(Token = "0x6005F02")]
    [Address(RVA = "0x1343330", Offset = "0x1342130", VA = "0x11343330")]
    private void reflectLoginTrophyProgs()
    {
    }

    [Token(Token = "0x6005F03")]
    [Address(RVA = "0x1342D00", Offset = "0x1341B00", VA = "0x11342D00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F04")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLoginPack()
    {
    }

    [Token(Token = "0x2001768")]
    [MessagePackObject(true)]
    public class JSON_ReqLoginPackResponse
    {
      [Token(Token = "0x4005414")]
      [FieldOffset(Offset = "0x8")]
      public JSON_QuestProgress[] quests;
      [Token(Token = "0x4005415")]
      [FieldOffset(Offset = "0xC")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x4005416")]
      [FieldOffset(Offset = "0x10")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x4005417")]
      [FieldOffset(Offset = "0x14")]
      public Json_ChatChannelMasterParam[] channels;
      [Token(Token = "0x4005418")]
      [FieldOffset(Offset = "0x18")]
      public int channel;
      [Token(Token = "0x4005419")]
      [FieldOffset(Offset = "0x20")]
      public long support;
      [Token(Token = "0x400541A")]
      [FieldOffset(Offset = "0x28")]
      public string device_id;
      [Token(Token = "0x400541B")]
      [FieldOffset(Offset = "0x2C")]
      public int is_pending;
      [Token(Token = "0x400541C")]
      [FieldOffset(Offset = "0x30")]
      public LoginNewsInfo.JSON_PubInfo pubinfo;
      [Token(Token = "0x400541D")]
      [FieldOffset(Offset = "0x34")]
      public JSON_QuestCombatPowers combat_powers;

      [Token(Token = "0x6005F05")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_ReqLoginPackResponse()
      {
      }
    }

    [Token(Token = "0x2001769")]
    [MessagePackObject(true)]
    public class MP_ReqLoginPackResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400541E")]
      [FieldOffset(Offset = "0x28")]
      public FlowNode_ReqLoginPack.JSON_ReqLoginPackResponse body;

      [Token(Token = "0x6005F06")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_ReqLoginPackResponse()
      {
      }
    }
  }
}
