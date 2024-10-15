// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRunePrideBoardOpen
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
  [Token(Token = "0x20032C6")]
  public class ReqRunePrideBoardOpen : WebAPI
  {
    [Token(Token = "0x600DF6A")]
    [Address(RVA = "0xA9BF50", Offset = "0xA9AD50", VA = "0x10A9BF50")]
    public ReqRunePrideBoardOpen(
      ReqRunePrideBoardOpen.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032C7")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF5B")]
      [FieldOffset(Offset = "0x8")]
      public long unit_id;
      [Token(Token = "0x400EF5C")]
      [FieldOffset(Offset = "0x10")]
      public string panel_iname;
      [Token(Token = "0x400EF5D")]
      [FieldOffset(Offset = "0x14")]
      public int[] target_numbers;

      [Token(Token = "0x600DF6B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DF6C")]
      [Address(RVA = "0xA7DE00", Offset = "0xA7CC00", VA = "0x10A7DE00")]
      public RequestParam(long _unit_id, string _panel_iname, int[] _target_numbers)
      {
      }
    }

    [Token(Token = "0x20032C8")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF5E")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdatePlayer difference_update;

      [Token(Token = "0x600DF6D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
