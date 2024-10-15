// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMultiSupportList
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
  [Token(Token = "0x200310F")]
  public class ReqMultiSupportList : WebAPI
  {
    [Token(Token = "0x600DDA2")]
    [Address(RVA = "0xA88A50", Offset = "0xA87850", VA = "0x10A88A50")]
    public ReqMultiSupportList(
      int roomId,
      bool isUpdate,
      List<string> selectedFUIDs,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003110")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EC7C")]
      [FieldOffset(Offset = "0x8")]
      public int roomid;
      [Token(Token = "0x400EC7D")]
      [FieldOffset(Offset = "0xC")]
      public int is_update;
      [Token(Token = "0x400EC7E")]
      [FieldOffset(Offset = "0x10")]
      public ReqMultiSupportList.RequestParamHelp[] helps;

      [Token(Token = "0x600DDA3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003111")]
    [Serializable]
    public class RequestParamHelp
    {
      [Token(Token = "0x400EC7F")]
      [FieldOffset(Offset = "0x8")]
      public string fuid;

      [Token(Token = "0x600DDA4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParamHelp()
      {
      }
    }

    [Token(Token = "0x2003112")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EC80")]
      [FieldOffset(Offset = "0x8")]
      public JSON_MultiSupport[] supports;

      [Token(Token = "0x600DDA5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
