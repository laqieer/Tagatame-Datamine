// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAutoRepeatQuestStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003245")]
  public class ReqAutoRepeatQuestStart : WebAPI
  {
    [Token(Token = "0x600DEE3")]
    [Address(RVA = "0xA938F0", Offset = "0xA926F0", VA = "0x10A938F0")]
    public ReqAutoRepeatQuestStart(
      string iname,
      int lap_num,
      bool is_full_box,
      bool use_drip,
      bool use_notification,
      Vector2 location,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003246")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE64")]
      [FieldOffset(Offset = "0x8")]
      public string quest_iname;
      [Token(Token = "0x400EE65")]
      [FieldOffset(Offset = "0xC")]
      public int lap_num;
      [Token(Token = "0x400EE66")]
      [FieldOffset(Offset = "0x10")]
      public int is_full_box;
      [Token(Token = "0x400EE67")]
      [FieldOffset(Offset = "0x14")]
      public int is_use_drip;
      [Token(Token = "0x400EE68")]
      [FieldOffset(Offset = "0x18")]
      public int is_push;
      [Token(Token = "0x400EE69")]
      [FieldOffset(Offset = "0x1C")]
      public ReqAutoRepeatQuestStart.Location location;

      [Token(Token = "0x600DEE4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003247")]
    [Serializable]
    public class Location
    {
      [Token(Token = "0x400EE6A")]
      [FieldOffset(Offset = "0x8")]
      public float lat;
      [Token(Token = "0x400EE6B")]
      [FieldOffset(Offset = "0xC")]
      public float lng;

      [Token(Token = "0x600DEE5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Location()
      {
      }
    }

    [Token(Token = "0x2003248")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE6C")]
      [FieldOffset(Offset = "0x8")]
      public Json_AutoRepeatQuestData auto_repeat;
      [Token(Token = "0x400EE6D")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;
      [Token(Token = "0x400EE6E")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;

      [Token(Token = "0x600DEE6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
