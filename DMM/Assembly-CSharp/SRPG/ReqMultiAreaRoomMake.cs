// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMultiAreaRoomMake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003167")]
  public class ReqMultiAreaRoomMake : WebAPI
  {
    [Token(Token = "0x600DDFD")]
    [Address(RVA = "0xA885C0", Offset = "0xA873C0", VA = "0x10A885C0")]
    public ReqMultiAreaRoomMake(
      string iname,
      string comment,
      string passCode,
      bool isPrivate,
      int btlSpeed,
      bool limit,
      int unitlv,
      bool clear,
      bool enable_auto,
      Vector2 location,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003168")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400ED25")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400ED26")]
      [FieldOffset(Offset = "0xC")]
      public string comment;
      [Token(Token = "0x400ED27")]
      [FieldOffset(Offset = "0x10")]
      public string pwd;
      [Token(Token = "0x400ED28")]
      [FieldOffset(Offset = "0x14")]
      public int @private;
      [Token(Token = "0x400ED29")]
      [FieldOffset(Offset = "0x18")]
      public int btl_speed;
      [Token(Token = "0x400ED2A")]
      [FieldOffset(Offset = "0x20")]
      public long req_at;
      [Token(Token = "0x400ED2B")]
      [FieldOffset(Offset = "0x28")]
      public int limit;
      [Token(Token = "0x400ED2C")]
      [FieldOffset(Offset = "0x2C")]
      public int unitlv;
      [Token(Token = "0x400ED2D")]
      [FieldOffset(Offset = "0x30")]
      public int clear;
      [Token(Token = "0x400ED2E")]
      [FieldOffset(Offset = "0x34")]
      public ReqMultiAreaRoomMake.RequestParam.Location location;
      [Token(Token = "0x400ED2F")]
      [FieldOffset(Offset = "0x38")]
      public int enable_auto;

      [Token(Token = "0x600DDFE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x2003169")]
      [Serializable]
      public class Location
      {
        [Token(Token = "0x400ED30")]
        [FieldOffset(Offset = "0x8")]
        public float lat;
        [Token(Token = "0x400ED31")]
        [FieldOffset(Offset = "0xC")]
        public float lng;

        [Token(Token = "0x600DDFF")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Location()
        {
        }
      }
    }

    [Token(Token = "0x200316A")]
    public class Response
    {
      [Token(Token = "0x400ED32")]
      [FieldOffset(Offset = "0x8")]
      public int roomid;
      [Token(Token = "0x400ED33")]
      [FieldOffset(Offset = "0xC")]
      public string app_id;
      [Token(Token = "0x400ED34")]
      [FieldOffset(Offset = "0x10")]
      public string token;
      [Token(Token = "0x400ED35")]
      [FieldOffset(Offset = "0x14")]
      public string btl_ver;

      [Token(Token = "0x600DE00")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
