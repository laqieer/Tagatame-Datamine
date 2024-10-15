// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneLotteryEvoStatePackFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000681")]
  public sealed class JSON_RuneLotteryEvoStatePackFormatter : 
    IMessagePackFormatter<JSON_RuneLotteryEvoStatePack>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400119A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400119B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CD1")]
    [Address(RVA = "0xC03A90", Offset = "0xC02890", VA = "0x10C03A90")]
    public JSON_RuneLotteryEvoStatePackFormatter()
    {
    }

    [Token(Token = "0x6001CD2")]
    [Address(RVA = "0xC038B0", Offset = "0xC026B0", VA = "0x10C038B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneLotteryEvoStatePack value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CD3")]
    [Address(RVA = "0xC03570", Offset = "0xC02370", VA = "0x10C03570", Slot = "5")]
    public JSON_RuneLotteryEvoStatePack Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneLotteryEvoStatePack) null;
    }
  }
}
