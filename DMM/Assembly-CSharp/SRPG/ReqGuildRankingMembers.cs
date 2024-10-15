// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRankingMembers
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
  [Token(Token = "0x2002E86")]
  public class ReqGuildRankingMembers : WebAPI
  {
    [Token(Token = "0x600DACD")]
    [Address(RVA = "0xA73E80", Offset = "0xA72C80", VA = "0x10A73E80")]
    public ReqGuildRankingMembers(
      int gid,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002E87")]
    [Serializable]
    public class Request
    {
      [Token(Token = "0x400E8B4")]
      [FieldOffset(Offset = "0x8")]
      public int gid;

      [Token(Token = "0x600DACE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Request()
      {
      }
    }

    [Token(Token = "0x2002E88")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8B5")]
      [FieldOffset(Offset = "0x8")]
      public JSON_CombatPowerRankingGuildMember[] ranking;

      [Token(Token = "0x600DACF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
