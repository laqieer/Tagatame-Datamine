// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneStorageAdd
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
  [Token(Token = "0x2003024")]
  public class ReqRuneStorageAdd : WebAPI
  {
    [Token(Token = "0x600DC86")]
    [Address(RVA = "0xA7A7D0", Offset = "0xA795D0", VA = "0x10A7A7D0")]
    public ReqRuneStorageAdd(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003025")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB86")]
      [FieldOffset(Offset = "0x8")]
      public int rune_storage;
      [Token(Token = "0x400EB87")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;

      [Token(Token = "0x600DC87")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
