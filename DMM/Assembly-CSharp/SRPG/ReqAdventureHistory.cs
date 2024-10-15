// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdventureHistory
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
  [Token(Token = "0x2002E4E")]
  public class ReqAdventureHistory : WebAPI
  {
    [Token(Token = "0x600DA92")]
    [Address(RVA = "0xA6B4D0", Offset = "0xA6A2D0", VA = "0x10A6B4D0")]
    public ReqAdventureHistory(
      string area_iname,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002E4F")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E86F")]
      [FieldOffset(Offset = "0x8")]
      public string area_iname;

      [Token(Token = "0x600DA93")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E50")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E870")]
      [FieldOffset(Offset = "0x8")]
      public JSON_AdventureHistory[] logs;

      [Token(Token = "0x600DA94")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
