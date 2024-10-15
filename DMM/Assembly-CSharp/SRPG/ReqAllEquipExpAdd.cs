// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAllEquipExpAdd
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
  [Token(Token = "0x20030CC")]
  public class ReqAllEquipExpAdd : WebAPI
  {
    [Token(Token = "0x600DD51")]
    [Address(RVA = "0xA806E0", Offset = "0xA7F4E0", VA = "0x10A806E0")]
    public ReqAllEquipExpAdd(
      long iid,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x20030CD")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EC3E")]
      [FieldOffset(Offset = "0x8")]
      public long iid;

      [Token(Token = "0x600DD52")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20030CE")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EC3F")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400EC40")]
      [FieldOffset(Offset = "0xC")]
      public Json_Unit[] units;
      [Token(Token = "0x400EC41")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;

      [Token(Token = "0x600DD53")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
