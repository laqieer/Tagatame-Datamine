// Decompiled with JetBrains decompiler
// Type: SRPG.ReqStoryExChallengeCountReset
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
  [Token(Token = "0x20030B3")]
  public class ReqStoryExChallengeCountReset : WebAPI
  {
    [Token(Token = "0x600DD33")]
    [Address(RVA = "0xA8BB70", Offset = "0xA8A970", VA = "0x10A8BB70")]
    public ReqStoryExChallengeCountReset(
      eResetCostType cost_type,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x20030B4")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EC30")]
      [FieldOffset(Offset = "0x8")]
      public int cost_type;

      [Token(Token = "0x600DD34")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20030B5")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EC31")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400EC32")]
      [FieldOffset(Offset = "0xC")]
      public JSON_StoryExChallengeCount story_ex_challenge;
      [Token(Token = "0x400EC33")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;

      [Token(Token = "0x600DD35")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
