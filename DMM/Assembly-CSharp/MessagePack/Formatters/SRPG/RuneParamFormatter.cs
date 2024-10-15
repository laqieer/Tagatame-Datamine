// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008F6")]
  public sealed class RuneParamFormatter : IMessagePackFormatter<RuneParam>, IMessagePackFormatter
  {
    [Token(Token = "0x400167C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400167D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002430")]
    [Address(RVA = "0xDF1F10", Offset = "0xDF0D10", VA = "0x10DF1F10")]
    public RuneParamFormatter()
    {
    }

    [Token(Token = "0x6002431")]
    [Address(RVA = "0xDF1980", Offset = "0xDF0780", VA = "0x10DF1980", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002432")]
    [Address(RVA = "0xDF1420", Offset = "0xDF0220", VA = "0x10DF1420", Slot = "5")]
    public RuneParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneParam) null;
    }
  }
}
