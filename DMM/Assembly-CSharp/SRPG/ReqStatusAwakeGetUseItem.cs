﻿// Decompiled with JetBrains decompiler
// Type: SRPG.ReqStatusAwakeGetUseItem
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
  [Token(Token = "0x2003044")]
  public class ReqStatusAwakeGetUseItem : WebAPI
  {
    [Token(Token = "0x600DCAA")]
    [Address(RVA = "0xA7B7E0", Offset = "0xA7A5E0", VA = "0x10A7B7E0")]
    public ReqStatusAwakeGetUseItem(
      long iid,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2003045")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBA6")]
      [FieldOffset(Offset = "0x8")]
      public long unit_id;

      [Token(Token = "0x600DCAB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003046")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EBA7")]
      [FieldOffset(Offset = "0x8")]
      public Json_StatusAwakeData[] used_items;

      [Token(Token = "0x600DCAC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2003047")]
    [MessagePackObject(true)]
    [Serializable]
    public class StatusAwakeGetUseItemResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EBA8")]
      [FieldOffset(Offset = "0x28")]
      public ReqStatusAwakeGetUseItem.Response body;

      [Token(Token = "0x600DCAD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public StatusAwakeGetUseItemResponse()
      {
      }
    }
  }
}