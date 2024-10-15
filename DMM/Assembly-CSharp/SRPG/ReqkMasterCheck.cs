// Decompiled with JetBrains decompiler
// Type: SRPG.ReqkMasterCheck
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
  [Token(Token = "0x20032BF")]
  public class ReqkMasterCheck : WebAPI
  {
    [Token(Token = "0x600DF62")]
    [Address(RVA = "0xA9F890", Offset = "0xA9E690", VA = "0x10A9F890")]
    public ReqkMasterCheck(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x20032C0")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF56")]
      [FieldOffset(Offset = "0x8")]
      public string master_digest;
      [Token(Token = "0x400EF57")]
      [FieldOffset(Offset = "0xC")]
      public string quest_digest;

      [Token(Token = "0x600DF63")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
