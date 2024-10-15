// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildTraining
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
  [Token(Token = "0x2002F0E")]
  public class ReqGuildTraining : WebAPI
  {
    [Token(Token = "0x600DB5C")]
    [Address(RVA = "0xA74F90", Offset = "0xA73D90", VA = "0x10A74F90")]
    public ReqGuildTraining(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F0F")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E980")]
      [FieldOffset(Offset = "0x8")]
      public Json_GuildTrainingData[] training_slots;
      [Token(Token = "0x400E981")]
      [FieldOffset(Offset = "0xC")]
      public Json_GuildTrainingEnergy energy;
      [Token(Token = "0x400E982")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;
      [Token(Token = "0x400E983")]
      [FieldOffset(Offset = "0x14")]
      public Json_GuildTrainingReward[] rewards;
      [Token(Token = "0x400E984")]
      [FieldOffset(Offset = "0x18")]
      public string[] remove_units;
      [Token(Token = "0x400E985")]
      [FieldOffset(Offset = "0x20")]
      public long request_time;

      [Token(Token = "0x600DB5D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
