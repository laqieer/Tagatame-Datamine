﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqSetConceptCardList_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000949")]
  public sealed class ReqSetConceptCardList_ResponseFormatter : 
    IMessagePackFormatter<ReqSetConceptCardList.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001722")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001723")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002529")]
    [Address(RVA = "0xE1E490", Offset = "0xE1D290", VA = "0x10E1E490")]
    public ReqSetConceptCardList_ResponseFormatter()
    {
    }

    [Token(Token = "0x600252A")]
    [Address(RVA = "0xE1E330", Offset = "0xE1D130", VA = "0x10E1E330", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqSetConceptCardList.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600252B")]
    [Address(RVA = "0xE1DFF0", Offset = "0xE1CDF0", VA = "0x10E1DFF0", Slot = "5")]
    public ReqSetConceptCardList.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqSetConceptCardList.Response) null;
    }
  }
}