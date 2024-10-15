// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGReward
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
  [Token(Token = "0x200327B")]
  public class ReqGvGReward : WebAPI
  {
    [Token(Token = "0x600DF1C")]
    [Address(RVA = "0xA99F20", Offset = "0xA98D20", VA = "0x10A99F20")]
    public ReqGvGReward(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200327C")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EEF9")]
      [FieldOffset(Offset = "0x8")]
      public int status;
      [Token(Token = "0x400EEFA")]
      [FieldOffset(Offset = "0xC")]
      public int period_id;
      [Token(Token = "0x400EEFB")]
      [FieldOffset(Offset = "0x10")]
      public string[] reward_ids;

      [Token(Token = "0x600DF1D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
