// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildTrainingEnergyAdd
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
  [Token(Token = "0x2002F16")]
  public class ReqGuildTrainingEnergyAdd : WebAPI
  {
    [Token(Token = "0x600DB65")]
    [Address(RVA = "0xA74B30", Offset = "0xA73930", VA = "0x10A74B30")]
    public ReqGuildTrainingEnergyAdd(
      int max_energy,
      int gold,
      Json_GuildTrainingAdd[] items,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F17")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E998")]
      [FieldOffset(Offset = "0x8")]
      public ReqGuildTrainingEnergyAdd.RequestParamDetail cost;
      [Token(Token = "0x400E999")]
      [FieldOffset(Offset = "0xC")]
      public int energy_limit;

      [Token(Token = "0x600DB66")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F18")]
    [Serializable]
    public class RequestParamDetail
    {
      [Token(Token = "0x400E99A")]
      [FieldOffset(Offset = "0x8")]
      public int gold;
      [Token(Token = "0x400E99B")]
      [FieldOffset(Offset = "0xC")]
      public Json_GuildTrainingAdd[] items;

      [Token(Token = "0x600DB67")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParamDetail()
      {
      }
    }

    [Token(Token = "0x2002F19")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E99C")]
      [FieldOffset(Offset = "0x8")]
      public Json_GuildTrainingData[] training_slots;
      [Token(Token = "0x400E99D")]
      [FieldOffset(Offset = "0xC")]
      public Json_GuildTrainingEnergy energy;
      [Token(Token = "0x400E99E")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;
      [Token(Token = "0x400E99F")]
      [FieldOffset(Offset = "0x14")]
      public Json_GuildTrainingReward[] rewards;
      [Token(Token = "0x400E9A0")]
      [FieldOffset(Offset = "0x18")]
      public string[] remove_units;
      [Token(Token = "0x400E9A1")]
      [FieldOffset(Offset = "0x1C")]
      public Json_PlayerData player;
      [Token(Token = "0x400E9A2")]
      [FieldOffset(Offset = "0x20")]
      public long request_time;

      [Token(Token = "0x600DB68")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
