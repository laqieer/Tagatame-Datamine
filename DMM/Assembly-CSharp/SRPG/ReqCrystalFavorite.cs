// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCrystalFavorite
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
  [Token(Token = "0x2002EBE")]
  public class ReqCrystalFavorite : WebAPI
  {
    [Token(Token = "0x600DB0A")]
    [Address(RVA = "0xA6E620", Offset = "0xA6D420", VA = "0x10A6E620")]
    public ReqCrystalFavorite(
      long _crystal_id,
      bool _is_favo,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EBF")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E8F7")]
      [FieldOffset(Offset = "0x8")]
      public long crystal_id;
      [Token(Token = "0x400E8F8")]
      [FieldOffset(Offset = "0x10")]
      public int is_favo;

      [Token(Token = "0x600DB0B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EC0")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8F9")]
      [FieldOffset(Offset = "0x8")]
      public JSON_CrystalData base_crystal;
      [Token(Token = "0x400E8FA")]
      [FieldOffset(Offset = "0xC")]
      public JSON_CrystalDifference difference_update;

      [Token(Token = "0x600DB0C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
