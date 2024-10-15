// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ResonanceResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000840")]
  public sealed class ResonanceResponseFormatter : 
    IMessagePackFormatter<ResonanceResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001510")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001511")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600220E")]
    [Address(RVA = "0xD7FC10", Offset = "0xD7EA10", VA = "0x10D7FC10")]
    public ResonanceResponseFormatter()
    {
    }

    [Token(Token = "0x600220F")]
    [Address(RVA = "0xD7F920", Offset = "0xD7E720", VA = "0x10D7F920", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ResonanceResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002210")]
    [Address(RVA = "0xD7F4F0", Offset = "0xD7E2F0", VA = "0x10D7F4F0", Slot = "5")]
    public ResonanceResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ResonanceResponse) null;
    }
  }
}
