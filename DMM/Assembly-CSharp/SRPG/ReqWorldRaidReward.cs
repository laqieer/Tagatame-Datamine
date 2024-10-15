// Decompiled with JetBrains decompiler
// Type: SRPG.ReqWorldRaidReward
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
  [Token(Token = "0x2003074")]
  public class ReqWorldRaidReward : WebAPI
  {
    [Token(Token = "0x600DCDE")]
    [Address(RVA = "0xA7DAD0", Offset = "0xA7C8D0", VA = "0x10A7DAD0")]
    public ReqWorldRaidReward(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2003075")]
    public enum RewardStatus
    {
      [Token(Token = "0x400EBF5")] None,
      [Token(Token = "0x400EBF6")] Granted,
    }

    [Token(Token = "0x2003076")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EBF7")]
      [FieldOffset(Offset = "0x8")]
      public ReqWorldRaidReward.RewardStatus status;

      [Token(Token = "0x600DCDF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
