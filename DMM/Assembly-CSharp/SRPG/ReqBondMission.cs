// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBondMission
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
  [Token(Token = "0x20032B1")]
  public class ReqBondMission : WebAPI
  {
    [Token(Token = "0x600DF54")]
    [Address(RVA = "0xA93CC0", Offset = "0xA92AC0", VA = "0x10A93CC0")]
    public ReqBondMission(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032B2")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF3D")]
      [FieldOffset(Offset = "0x8")]
      public JSON_BondMissionData[] missions;

      [Token(Token = "0x600DF55")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
