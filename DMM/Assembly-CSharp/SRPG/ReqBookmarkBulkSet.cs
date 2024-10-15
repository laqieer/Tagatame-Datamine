// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBookmarkBulkSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031CC")]
  public class ReqBookmarkBulkSet : WebAPI
  {
    [Token(Token = "0x600DE65")]
    [Address(RVA = "0xA93EE0", Offset = "0xA92CE0", VA = "0x10A93EE0")]
    public ReqBookmarkBulkSet(
      string[] _favorites,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20031CD")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400ED95")]
      [FieldOffset(Offset = "0x8")]
      public string[] favorites;

      [Token(Token = "0x600DE66")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
