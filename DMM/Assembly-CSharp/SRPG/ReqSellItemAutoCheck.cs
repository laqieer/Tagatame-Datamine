﻿// Decompiled with JetBrains decompiler
// Type: SRPG.ReqSellItemAutoCheck
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
  [Token(Token = "0x20030D5")]
  public class ReqSellItemAutoCheck : WebAPI
  {
    [Token(Token = "0x600DD5A")]
    [Address(RVA = "0xA8B350", Offset = "0xA8A150", VA = "0x10A8B350")]
    public ReqSellItemAutoCheck(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20030D6")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EC47")]
      [FieldOffset(Offset = "0x8")]
      public int isAuto;

      [Token(Token = "0x600DD5B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}