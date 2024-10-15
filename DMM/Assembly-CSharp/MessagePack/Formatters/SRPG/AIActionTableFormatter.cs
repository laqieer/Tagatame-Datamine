// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AIActionTableFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007C5")]
  public sealed class AIActionTableFormatter : 
    IMessagePackFormatter<AIActionTable>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400141A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400141B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600209D")]
    [Address(RVA = "0xCFF730", Offset = "0xCFE530", VA = "0x10CFF730")]
    public AIActionTableFormatter()
    {
    }

    [Token(Token = "0x600209E")]
    [Address(RVA = "0xCFF580", Offset = "0xCFE380", VA = "0x10CFF580", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AIActionTable value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600209F")]
    [Address(RVA = "0xCFF270", Offset = "0xCFE070", VA = "0x10CFF270", Slot = "5")]
    public AIActionTable Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AIActionTable) null;
    }
  }
}
