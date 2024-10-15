// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidRescueSend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FD1")]
  public class ReqRaidRescueSend : WebAPI
  {
    [Token(Token = "0x600DC25")]
    [Address(RVA = "0xA79210", Offset = "0xA78010", VA = "0x10A79210")]
    public ReqRaidRescueSend(
      int area_id,
      int boss_id,
      int round,
      int is_send_guild,
      int is_send_friend,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FD2")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EAF9")]
      [FieldOffset(Offset = "0x8")]
      public int area_id;
      [Token(Token = "0x400EAFA")]
      [FieldOffset(Offset = "0xC")]
      public int boss_id;
      [Token(Token = "0x400EAFB")]
      [FieldOffset(Offset = "0x10")]
      public int round;
      [Token(Token = "0x400EAFC")]
      [FieldOffset(Offset = "0x14")]
      public int is_send_guild;
      [Token(Token = "0x400EAFD")]
      [FieldOffset(Offset = "0x18")]
      public int is_send_friend;

      [Token(Token = "0x600DC26")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
