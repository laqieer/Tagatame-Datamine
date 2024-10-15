// Decompiled with JetBrains decompiler
// Type: SRPG.ReqSetSupportUsed
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
  [Token(Token = "0x20031BA")]
  public class ReqSetSupportUsed : WebAPI
  {
    [Token(Token = "0x600DE53")]
    [Address(RVA = "0xA9CDA0", Offset = "0xA9BBA0", VA = "0x10A9CDA0")]
    public ReqSetSupportUsed(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x20031BB")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400ED7A")]
      [FieldOffset(Offset = "0x8")]
      public string[] unit_ids;

      [Token(Token = "0x600DE54")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20031BC")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400ED7B")]
      [FieldOffset(Offset = "0x8")]
      public JSON_SupportHistory[] units;

      [Token(Token = "0x600DE55")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
