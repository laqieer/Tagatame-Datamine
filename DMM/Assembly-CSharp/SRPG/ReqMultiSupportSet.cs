// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMultiSupportSet
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
  [Token(Token = "0x2003114")]
  public class ReqMultiSupportSet : WebAPI
  {
    [Token(Token = "0x600DDA9")]
    [Address(RVA = "0xA88C30", Offset = "0xA87A30", VA = "0x10A88C30")]
    public ReqMultiSupportSet(
      int roomId,
      List<string> selectedUIDs,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003115")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EC83")]
      [FieldOffset(Offset = "0x8")]
      public int roomid;
      [Token(Token = "0x400EC84")]
      [FieldOffset(Offset = "0xC")]
      public string[] support_uids;

      [Token(Token = "0x600DDAA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003116")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x600DDAB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
