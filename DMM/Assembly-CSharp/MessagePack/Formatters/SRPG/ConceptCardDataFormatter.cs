﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ConceptCardDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000780")]
  public sealed class ConceptCardDataFormatter : 
    IMessagePackFormatter<ConceptCardData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001398")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001399")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FCE")]
    [Address(RVA = "0xCC70F0", Offset = "0xCC5EF0", VA = "0x10CC70F0")]
    public ConceptCardDataFormatter()
    {
    }

    [Token(Token = "0x6001FCF")]
    [Address(RVA = "0xCC6600", Offset = "0xCC5400", VA = "0x10CC6600", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ConceptCardData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FD0")]
    [Address(RVA = "0xCC6100", Offset = "0xCC4F00", VA = "0x10CC6100", Slot = "5")]
    public ConceptCardData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ConceptCardData) null;
    }
  }
}