﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePrideReleasePanelFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200079D")]
  public sealed class RunePrideReleasePanelFormatter : 
    IMessagePackFormatter<RunePrideReleasePanel>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013D2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013D3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002025")]
    [Address(RVA = "0xCE0F40", Offset = "0xCDFD40", VA = "0x10CE0F40")]
    public RunePrideReleasePanelFormatter()
    {
    }

    [Token(Token = "0x6002026")]
    [Address(RVA = "0xCE0D60", Offset = "0xCDFB60", VA = "0x10CE0D60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePrideReleasePanel value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002027")]
    [Address(RVA = "0xCE0A30", Offset = "0xCDF830", VA = "0x10CE0A30", Slot = "5")]
    public RunePrideReleasePanel Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePrideReleasePanel) null;
    }
  }
}