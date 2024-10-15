// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.CondEffectFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007A9")]
  public sealed class CondEffectFormatter : IMessagePackFormatter<CondEffect>, IMessagePackFormatter
  {
    [Token(Token = "0x40013E6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013E7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002049")]
    [Address(RVA = "0xCF1F60", Offset = "0xCF0D60", VA = "0x10CF1F60")]
    public CondEffectFormatter()
    {
    }

    [Token(Token = "0x600204A")]
    [Address(RVA = "0xCF1CC0", Offset = "0xCF0AC0", VA = "0x10CF1CC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      CondEffect value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600204B")]
    [Address(RVA = "0xCF1880", Offset = "0xCF0680", VA = "0x10CF1880", Slot = "5")]
    public CondEffect Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (CondEffect) null;
    }
  }
}
