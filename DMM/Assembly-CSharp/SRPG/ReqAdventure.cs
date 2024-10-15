// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdventure
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
  [Token(Token = "0x2002E3E")]
  public class ReqAdventure : WebAPI
  {
    [Token(Token = "0x600DA82")]
    [Address(RVA = "0xA6B9C0", Offset = "0xA6A7C0", VA = "0x10A6B9C0")]
    public ReqAdventure(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002E3F")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E84E")]
      [FieldOffset(Offset = "0x8")]
      public JSON_AdventureData[] adventure_areas;
      [Token(Token = "0x400E84F")]
      [FieldOffset(Offset = "0xC")]
      public int sally_count;
      [Token(Token = "0x400E850")]
      [FieldOffset(Offset = "0x10")]
      public int adventure_end_count;

      [Token(Token = "0x600DA83")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
