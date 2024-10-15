// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneLotteryEvoStatePackFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008F4")]
  public sealed class RuneLotteryEvoStatePackFormatter : 
    IMessagePackFormatter<RuneLotteryEvoStatePack>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001678")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001679")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600242A")]
    [Address(RVA = "0xDEF930", Offset = "0xDEE730", VA = "0x10DEF930")]
    public RuneLotteryEvoStatePackFormatter()
    {
    }

    [Token(Token = "0x600242B")]
    [Address(RVA = "0xDEF740", Offset = "0xDEE540", VA = "0x10DEF740", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneLotteryEvoStatePack value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600242C")]
    [Address(RVA = "0xDEF3A0", Offset = "0xDEE1A0", VA = "0x10DEF3A0", Slot = "5")]
    public RuneLotteryEvoStatePack Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneLotteryEvoStatePack) null;
    }
  }
}
