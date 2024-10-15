// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchBattleShamBuff
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
  [Token(Token = "0x2002F8A")]
  public class ReqLeagueMatchBattleShamBuff : WebAPI
  {
    [Token(Token = "0x600DBDD")]
    [Address(RVA = "0xA75AF0", Offset = "0xA748F0", VA = "0x10A75AF0")]
    public ReqLeagueMatchBattleShamBuff(
      ReqLeagueMatchBattleShamBuff.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F8B")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA58")]
      [FieldOffset(Offset = "0x8")]
      public string[] buffs;

      [Token(Token = "0x600DBDE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F8C")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA59")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchShamInfo defense_sham_info;

      [Token(Token = "0x600DBDF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
