// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMPRoomMake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030FC")]
  public class ReqMPRoomMake : WebAPI
  {
    [Token(Token = "0x600DD8F")]
    [Address(RVA = "0xA87500", Offset = "0xA86300", VA = "0x10A87500")]
    public ReqMPRoomMake(
      string iname,
      string comment,
      string passCode,
      bool isPrivate,
      int btlSpeed,
      bool limit,
      int unitlv,
      bool clear,
      bool enable_auto,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20030FD")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EC5A")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400EC5B")]
      [FieldOffset(Offset = "0xC")]
      public string comment;
      [Token(Token = "0x400EC5C")]
      [FieldOffset(Offset = "0x10")]
      public string pwd;
      [Token(Token = "0x400EC5D")]
      [FieldOffset(Offset = "0x14")]
      public int @private;
      [Token(Token = "0x400EC5E")]
      [FieldOffset(Offset = "0x18")]
      public int btl_speed;
      [Token(Token = "0x400EC5F")]
      [FieldOffset(Offset = "0x20")]
      public long req_at;
      [Token(Token = "0x400EC60")]
      [FieldOffset(Offset = "0x28")]
      public int limit;
      [Token(Token = "0x400EC61")]
      [FieldOffset(Offset = "0x2C")]
      public int unitlv;
      [Token(Token = "0x400EC62")]
      [FieldOffset(Offset = "0x30")]
      public int clear;
      [Token(Token = "0x400EC63")]
      [FieldOffset(Offset = "0x34")]
      public int enable_auto;

      [Token(Token = "0x600DD90")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20030FE")]
    public class Response
    {
      [Token(Token = "0x400EC64")]
      [FieldOffset(Offset = "0x8")]
      public int roomid;
      [Token(Token = "0x400EC65")]
      [FieldOffset(Offset = "0xC")]
      public string app_id;
      [Token(Token = "0x400EC66")]
      [FieldOffset(Offset = "0x10")]
      public string token;
      [Token(Token = "0x400EC67")]
      [FieldOffset(Offset = "0x14")]
      public string btl_ver;

      [Token(Token = "0x600DD91")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
