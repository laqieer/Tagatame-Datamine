// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AIActionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007C4")]
  public sealed class AIActionFormatter : IMessagePackFormatter<AIAction>, IMessagePackFormatter
  {
    [Token(Token = "0x4001418")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001419")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600209A")]
    [Address(RVA = "0xCFEDF0", Offset = "0xCFDBF0", VA = "0x10CFEDF0")]
    public AIActionFormatter()
    {
    }

    [Token(Token = "0x600209B")]
    [Address(RVA = "0xCFE9C0", Offset = "0xCFD7C0", VA = "0x10CFE9C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AIAction value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600209C")]
    [Address(RVA = "0xCFE3E0", Offset = "0xCFD1E0", VA = "0x10CFE3E0", Slot = "5")]
    public AIAction Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AIAction) null;
    }
  }
}
