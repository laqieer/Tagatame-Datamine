// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeMhmDmgFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000743")]
  public sealed class MultiPlayResumeMhmDmgFormatter : 
    IMessagePackFormatter<MultiPlayResumeMhmDmg>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400131E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400131F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F17")]
    [Address(RVA = "0xC8D1A0", Offset = "0xC8BFA0", VA = "0x10C8D1A0")]
    public MultiPlayResumeMhmDmgFormatter()
    {
    }

    [Token(Token = "0x6001F18")]
    [Address(RVA = "0xC8D0A0", Offset = "0xC8BEA0", VA = "0x10C8D0A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeMhmDmg value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F19")]
    [Address(RVA = "0xC8CDC0", Offset = "0xC8BBC0", VA = "0x10C8CDC0", Slot = "5")]
    public MultiPlayResumeMhmDmg Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeMhmDmg) null;
    }
  }
}
