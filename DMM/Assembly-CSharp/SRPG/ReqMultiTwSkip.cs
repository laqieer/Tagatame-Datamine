// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMultiTwSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003164")]
  public class ReqMultiTwSkip : WebAPI
  {
    [Token(Token = "0x600DDFA")]
    [Address(RVA = "0xA893B0", Offset = "0xA881B0", VA = "0x10A893B0")]
    public ReqMultiTwSkip(string tower_id, int skip_floor, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003165")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400ED21")]
      [FieldOffset(Offset = "0x8")]
      public ReqMultiTwStatus.FloorParam[] floors;
      [Token(Token = "0x400ED22")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerDataAll player;

      [Token(Token = "0x600DDFB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2003166")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400ED23")]
      [FieldOffset(Offset = "0x8")]
      public string tower_id;
      [Token(Token = "0x400ED24")]
      [FieldOffset(Offset = "0xC")]
      public int floor;

      [Token(Token = "0x600DDFC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
