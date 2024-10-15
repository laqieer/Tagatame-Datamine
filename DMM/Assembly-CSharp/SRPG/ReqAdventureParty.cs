// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdventureParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E40")]
  public class ReqAdventureParty : WebAPI
  {
    [Token(Token = "0x600DA84")]
    [Address(RVA = "0xA6B5E0", Offset = "0xA6A3E0", VA = "0x10A6B5E0")]
    public ReqAdventureParty(
      string area_iname,
      List<long> units,
      int combat_power,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002E41")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E851")]
      [FieldOffset(Offset = "0x8")]
      public string area_iname;
      [Token(Token = "0x400E852")]
      [FieldOffset(Offset = "0xC")]
      public int[] units;
      [Token(Token = "0x400E853")]
      [FieldOffset(Offset = "0x10")]
      public int combat_power;

      [Token(Token = "0x600DA85")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E42")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E854")]
      [FieldOffset(Offset = "0x8")]
      public JSON_AdventureData[] adventure_areas;

      [Token(Token = "0x600DA86")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
