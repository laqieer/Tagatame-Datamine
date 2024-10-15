// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGalleryHighlight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001505")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1001, "ハイライトデータ作成中", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1000, "ハイライト期間外", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/ReqGalleryHighlight", 32741)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqGalleryHighlight : FlowNode_Network
  {
    [Token(Token = "0x4004D01")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x4004D02")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4004D03")]
    public const int PIN_OUT_HIGHLIGHT_OUTOFPERIOD = 1000;
    [Token(Token = "0x4004D04")]
    public const int PIN_OUT_HIGHLIGHT_INPROGRESS = 1001;

    [Token(Token = "0x600575F")]
    [Address(RVA = "0x12CE740", Offset = "0x12CD540", VA = "0x112CE740", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005760")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005761")]
    [Address(RVA = "0x12CE7F0", Offset = "0x12CD5F0", VA = "0x112CE7F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005762")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGalleryHighlight()
    {
    }

    [Token(Token = "0x2001506")]
    [Serializable]
    public class Json_Response
    {
      [Token(Token = "0x4004D05")]
      [FieldOffset(Offset = "0x8")]
      public string highlight_iname;
      [Token(Token = "0x4004D06")]
      [FieldOffset(Offset = "0xC")]
      public int highlight_status;
      [Token(Token = "0x4004D07")]
      [FieldOffset(Offset = "0x10")]
      public int is_highlight_rewarded;
      [Token(Token = "0x4004D08")]
      [FieldOffset(Offset = "0x14")]
      public int is_mail_reward;
      [Token(Token = "0x4004D09")]
      [FieldOffset(Offset = "0x18")]
      public FlowNode_ReqGalleryHighlight.JSON_HighlightInfo highlight_info;

      [Token(Token = "0x6005763")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_Response()
      {
      }
    }

    [Token(Token = "0x2001507")]
    [Serializable]
    public class JSON_HighlightInfo
    {
      [Token(Token = "0x4004D0A")]
      [FieldOffset(Offset = "0x8")]
      public FlowNode_ReqGalleryHighlight.JSON_HighlightPlayer player;
      [Token(Token = "0x4004D0B")]
      [FieldOffset(Offset = "0xC")]
      public FlowNode_ReqGalleryHighlight.JSON_HighlightQuest quest;
      [Token(Token = "0x4004D0C")]
      [FieldOffset(Offset = "0x10")]
      public FlowNode_ReqGalleryHighlight.JSON_HighlightGallery gallery;
      [Token(Token = "0x4004D0D")]
      [FieldOffset(Offset = "0x14")]
      public FlowNode_ReqGalleryHighlight.JSON_HighlightArena arena;
      [Token(Token = "0x4004D0E")]
      [FieldOffset(Offset = "0x18")]
      public FlowNode_ReqGalleryHighlight.JSON_HighlightTower tower;
      [Token(Token = "0x4004D0F")]
      [FieldOffset(Offset = "0x1C")]
      public FlowNode_ReqGalleryHighlight.JSON_HighlightGuild guild;
      [Token(Token = "0x4004D10")]
      [FieldOffset(Offset = "0x20")]
      public FlowNode_ReqGalleryHighlight.JSON_HighlightFriend friend;

      [Token(Token = "0x6005764")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_HighlightInfo()
      {
      }
    }

    [Token(Token = "0x2001508")]
    [Serializable]
    public class JSON_HighlightPlayer
    {
      [Token(Token = "0x4004D11")]
      [FieldOffset(Offset = "0x8")]
      public string name;
      [Token(Token = "0x4004D12")]
      [FieldOffset(Offset = "0x10")]
      public long game_start;

      [Token(Token = "0x6005765")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_HighlightPlayer()
      {
      }
    }

    [Token(Token = "0x2001509")]
    [Serializable]
    public class JSON_HighlightQuest
    {
      [Token(Token = "0x4004D13")]
      [FieldOffset(Offset = "0x8")]
      public int clear_count;

      [Token(Token = "0x6005766")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_HighlightQuest()
      {
      }
    }

    [Token(Token = "0x200150A")]
    [Serializable]
    public class JSON_HighlightGallery
    {
      [Token(Token = "0x4004D14")]
      [FieldOffset(Offset = "0x8")]
      public int unit_count;
      [Token(Token = "0x4004D15")]
      [FieldOffset(Offset = "0xC")]
      public int concept_card_count;
      [Token(Token = "0x4004D16")]
      [FieldOffset(Offset = "0x10")]
      public int artifact_count;

      [Token(Token = "0x6005767")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_HighlightGallery()
      {
      }
    }

    [Token(Token = "0x200150B")]
    [Serializable]
    public class JSON_HighlightArena
    {
      [Token(Token = "0x4004D17")]
      [FieldOffset(Offset = "0x8")]
      public int rank_best;

      [Token(Token = "0x6005768")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_HighlightArena()
      {
      }
    }

    [Token(Token = "0x200150C")]
    [Serializable]
    public class JSON_HighlightTower
    {
      [Token(Token = "0x4004D18")]
      [FieldOffset(Offset = "0x8")]
      public int veda_clear_floor;
      [Token(Token = "0x4004D19")]
      [FieldOffset(Offset = "0xC")]
      public int mebius_clear_floor;

      [Token(Token = "0x6005769")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_HighlightTower()
      {
      }
    }

    [Token(Token = "0x200150D")]
    [Serializable]
    public class JSON_HighlightGuild
    {
      [Token(Token = "0x4004D1A")]
      [FieldOffset(Offset = "0x8")]
      public string guild_name;
      [Token(Token = "0x4004D1B")]
      [FieldOffset(Offset = "0xC")]
      public int join_days;
      [Token(Token = "0x4004D1C")]
      [FieldOffset(Offset = "0x10")]
      public int level;
      [Token(Token = "0x4004D1D")]
      [FieldOffset(Offset = "0x14")]
      public int member_count;
      [Token(Token = "0x4004D1E")]
      [FieldOffset(Offset = "0x18")]
      public int role_id;

      [Token(Token = "0x600576A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_HighlightGuild()
      {
      }
    }

    [Token(Token = "0x200150E")]
    [Serializable]
    public class JSON_HighlightFriend
    {
      [Token(Token = "0x4004D1F")]
      [FieldOffset(Offset = "0x8")]
      public int count;

      [Token(Token = "0x600576B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_HighlightFriend()
      {
      }
    }
  }
}
