// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdventureBook
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
  [Token(Token = "0x2002E4C")]
  public class ReqAdventureBook : WebAPI
  {
    [Token(Token = "0x600DA90")]
    [Address(RVA = "0xA6B1E0", Offset = "0xA69FE0", VA = "0x10A6B1E0")]
    public ReqAdventureBook(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002E4D")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E86E")]
      [FieldOffset(Offset = "0x8")]
      public JSON_AdventureBook[] books;

      [Token(Token = "0x600DA91")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
