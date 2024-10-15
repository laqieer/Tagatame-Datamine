// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlagManagerFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000764")]
  public sealed class FlagManagerFormatter : 
    IMessagePackFormatter<FlagManager>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001360")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001361")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F7A")]
    [Address(RVA = "0xCAF800", Offset = "0xCAE600", VA = "0x10CAF800")]
    public FlagManagerFormatter()
    {
    }

    [Token(Token = "0x6001F7B")]
    [Address(RVA = "0xCAF7B0", Offset = "0xCAE5B0", VA = "0x10CAF7B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlagManager value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F7C")]
    [Address(RVA = "0xCAF540", Offset = "0xCAE340", VA = "0x10CAF540", Slot = "5")]
    public FlagManager Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new FlagManager();
    }
  }
}
