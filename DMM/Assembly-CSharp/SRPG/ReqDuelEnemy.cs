// Decompiled with JetBrains decompiler
// Type: SRPG.ReqDuelEnemy
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
  [Token(Token = "0x2002ED4")]
  public class ReqDuelEnemy : WebAPI
  {
    [Token(Token = "0x600DB20")]
    [Address(RVA = "0xA6F6B0", Offset = "0xA6E4B0", VA = "0x10A6F6B0")]
    public ReqDuelEnemy(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002ED5")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E91A")]
      [FieldOffset(Offset = "0x8")]
      public JSON_DuelMapData map_data;
      [Token(Token = "0x400E91B")]
      [FieldOffset(Offset = "0xC")]
      public JSON_DuelPlayerData[] duel_enemies;

      [Token(Token = "0x600DB21")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
