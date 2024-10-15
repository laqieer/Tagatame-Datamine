// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchMission
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
  [Token(Token = "0x2002F8D")]
  public class ReqLeagueMatchMission : WebAPI
  {
    [Token(Token = "0x600DBE0")]
    [Address(RVA = "0xA760E0", Offset = "0xA74EE0", VA = "0x10A760E0")]
    public ReqLeagueMatchMission(
      ReqLeagueMatchMission.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F8E")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA5A")]
      [FieldOffset(Offset = "0x8")]
      public string[] inames;

      [Token(Token = "0x600DBE1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F8F")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA5B")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchMission[] missions;

      [Token(Token = "0x600DBE2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
