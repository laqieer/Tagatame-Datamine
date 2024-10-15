// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMastery
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
  [Token(Token = "0x2002F96")]
  public class ReqMastery : WebAPI
  {
    [Token(Token = "0x600DBE9")]
    [Address(RVA = "0xA76BA0", Offset = "0xA759A0", VA = "0x10A76BA0")]
    public ReqMastery(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F97")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA62")]
      [FieldOffset(Offset = "0x8")]
      public JSON_MasteryRewardStatusData[] mastery_rewards;
      [Token(Token = "0x400EA63")]
      [FieldOffset(Offset = "0xC")]
      public int mastery_rank;
      [Token(Token = "0x400EA64")]
      [FieldOffset(Offset = "0x10")]
      public int unit_door_max_num;

      [Token(Token = "0x600DBEA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
