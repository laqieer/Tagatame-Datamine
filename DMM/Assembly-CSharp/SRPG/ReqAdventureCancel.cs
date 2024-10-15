// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdventureCancel
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
  [Token(Token = "0x2002E49")]
  public class ReqAdventureCancel : WebAPI
  {
    [Token(Token = "0x600DA8D")]
    [Address(RVA = "0xA6B2B0", Offset = "0xA6A0B0", VA = "0x10A6B2B0")]
    public ReqAdventureCancel(
      string area_iname,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002E4A")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E86C")]
      [FieldOffset(Offset = "0x8")]
      public string area_iname;

      [Token(Token = "0x600DA8E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E4B")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E86D")]
      [FieldOffset(Offset = "0x8")]
      public JSON_AdventureData[] adventure_areas;

      [Token(Token = "0x600DA8F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
