﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneStorageAdd_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000872")]
  public sealed class FlowNode_ReqRuneStorageAdd_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneStorageAdd.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001574")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001575")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022A4")]
    [Address(RVA = "0xD9C7A0", Offset = "0xD9B5A0", VA = "0x10D9C7A0")]
    public FlowNode_ReqRuneStorageAdd_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60022A5")]
    [Address(RVA = "0xD9C4B0", Offset = "0xD9B2B0", VA = "0x10D9C4B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneStorageAdd.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022A6")]
    [Address(RVA = "0xD9C080", Offset = "0xD9AE80", VA = "0x10D9C080", Slot = "5")]
    public FlowNode_ReqRuneStorageAdd.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneStorageAdd.MP_Response) null;
    }
  }
}