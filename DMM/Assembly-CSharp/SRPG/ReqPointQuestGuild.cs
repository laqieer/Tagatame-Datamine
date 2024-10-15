// Decompiled with JetBrains decompiler
// Type: SRPG.ReqPointQuestGuild
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
  [Token(Token = "0x2002FBC")]
  public class ReqPointQuestGuild : WebAPI
  {
    [Token(Token = "0x600DC10")]
    [Address(RVA = "0xA77B80", Offset = "0xA76980", VA = "0x10A77B80")]
    public ReqPointQuestGuild(
      string eventIname,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002FBD")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EAAC")]
      [FieldOffset(Offset = "0x8")]
      public string event_iname;

      [Token(Token = "0x600DC11")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FBE")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EAAD")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PointQuestRewardStatusData[] reward_statuses;
      [Token(Token = "0x400EAAE")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PointQuestGuildInfoData guild_info;
      [Token(Token = "0x400EAAF")]
      [FieldOffset(Offset = "0x10")]
      public int guild_total_point;

      [Token(Token = "0x600DC12")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
