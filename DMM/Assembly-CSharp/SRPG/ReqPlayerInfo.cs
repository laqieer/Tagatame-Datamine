// Decompiled with JetBrains decompiler
// Type: SRPG.ReqPlayerInfo
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
  [Token(Token = "0x2002FAB")]
  public class ReqPlayerInfo : WebAPI
  {
    [Token(Token = "0x600DBFF")]
    [Address(RVA = "0xA77770", Offset = "0xA76570", VA = "0x10A77770")]
    public ReqPlayerInfo(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod method = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002FAC")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA86")]
      [FieldOffset(Offset = "0x8")]
      public string name;
      [Token(Token = "0x400EA87")]
      [FieldOffset(Offset = "0xC")]
      public string customid;
      [Token(Token = "0x400EA88")]
      [FieldOffset(Offset = "0x10")]
      public string fuid;

      [Token(Token = "0x600DC00")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
