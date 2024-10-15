// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildTrophy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003295")]
  public class ReqGuildTrophy : WebAPI
  {
    [Token(Token = "0x600DF36")]
    [Address(RVA = "0xA98FB0", Offset = "0xA97DB0", VA = "0x10A98FB0")]
    public ReqGuildTrophy(
      ReqGuildTrophy.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003296")]
    public class RequestParam
    {
      [Token(Token = "0x600DF37")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003297")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF1D")]
      [FieldOffset(Offset = "0x8")]
      public JSON_TrophyProgress[] guild_trophies;

      [Token(Token = "0x600DF38")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
