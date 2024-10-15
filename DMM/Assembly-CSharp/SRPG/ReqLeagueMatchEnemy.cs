// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchEnemy
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
  [Token(Token = "0x2002F60")]
  public class ReqLeagueMatchEnemy : WebAPI
  {
    [Token(Token = "0x600DBB3")]
    [Address(RVA = "0xA75F00", Offset = "0xA74D00", VA = "0x10A75F00")]
    public ReqLeagueMatchEnemy(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F61")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA26")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchEnemies[] enemies;

      [Token(Token = "0x600DBB4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002F62")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqLeagueMatchEnemyResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EA27")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchEnemy.Response body;

      [Token(Token = "0x600DBB5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqLeagueMatchEnemyResponse()
      {
      }
    }
  }
}
