// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidTraining
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
  [Token(Token = "0x2002F4C")]
  public class ReqGuildRaidTraining : WebAPI
  {
    [Token(Token = "0x600DB9D")]
    [Address(RVA = "0xA73C80", Offset = "0xA72A80", VA = "0x10A73C80")]
    public ReqGuildRaidTraining(
      int period_id,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F4D")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA05")]
      [FieldOffset(Offset = "0x8")]
      public int period_id;

      [Token(Token = "0x600DB9E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F4E")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA06")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildRaidTrainingPeriod[] periods;

      [Token(Token = "0x600DB9F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
