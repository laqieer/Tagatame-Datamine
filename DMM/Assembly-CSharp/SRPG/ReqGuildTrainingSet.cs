// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildTrainingSet
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
  [Token(Token = "0x2002F10")]
  public class ReqGuildTrainingSet : WebAPI
  {
    [Token(Token = "0x600DB5E")]
    [Address(RVA = "0xA74D60", Offset = "0xA73B60", VA = "0x10A74D60")]
    public ReqGuildTrainingSet(
      int slot_no,
      long iid,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x600DB5F")]
    [Address(RVA = "0xA74E70", Offset = "0xA73C70", VA = "0x10A74E70")]
    public ReqGuildTrainingSet(
      string expansion,
      int slot_no,
      long iid,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F11")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E986")]
      [FieldOffset(Offset = "0x8")]
      public int no;
      [Token(Token = "0x400E987")]
      [FieldOffset(Offset = "0x10")]
      public long unit_iid;

      [Token(Token = "0x600DB60")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F12")]
    [Serializable]
    public class RequestExpansionParam
    {
      [Token(Token = "0x400E988")]
      [FieldOffset(Offset = "0x8")]
      public string expansion_id;
      [Token(Token = "0x400E989")]
      [FieldOffset(Offset = "0xC")]
      public int no;
      [Token(Token = "0x400E98A")]
      [FieldOffset(Offset = "0x10")]
      public long unit_iid;

      [Token(Token = "0x600DB61")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestExpansionParam()
      {
      }
    }

    [Token(Token = "0x2002F13")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E98B")]
      [FieldOffset(Offset = "0x8")]
      public Json_GuildTrainingData[] training_slots;
      [Token(Token = "0x400E98C")]
      [FieldOffset(Offset = "0xC")]
      public Json_GuildTrainingEnergy energy;
      [Token(Token = "0x400E98D")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;
      [Token(Token = "0x400E98E")]
      [FieldOffset(Offset = "0x14")]
      public Json_GuildTrainingReward[] rewards;
      [Token(Token = "0x400E98F")]
      [FieldOffset(Offset = "0x18")]
      public string[] remove_units;
      [Token(Token = "0x400E990")]
      [FieldOffset(Offset = "0x1C")]
      public Json_PlayerData player;
      [Token(Token = "0x400E991")]
      [FieldOffset(Offset = "0x20")]
      public long request_time;

      [Token(Token = "0x600DB62")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
