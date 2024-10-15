// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneLotteryEvoStateFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200067B")]
  public sealed class JSON_RuneLotteryEvoStateFormatter : 
    IMessagePackFormatter<JSON_RuneLotteryEvoState>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400118E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400118F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CBF")]
    [Address(RVA = "0xBEA000", Offset = "0xBE8E00", VA = "0x10BEA000")]
    public JSON_RuneLotteryEvoStateFormatter()
    {
    }

    [Token(Token = "0x6001CC0")]
    [Address(RVA = "0xBE9E30", Offset = "0xBE8C30", VA = "0x10BE9E30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneLotteryEvoState value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CC1")]
    [Address(RVA = "0xBE9A90", Offset = "0xBE8890", VA = "0x10BE9A90", Slot = "5")]
    public JSON_RuneLotteryEvoState Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneLotteryEvoState) null;
    }
  }
}
