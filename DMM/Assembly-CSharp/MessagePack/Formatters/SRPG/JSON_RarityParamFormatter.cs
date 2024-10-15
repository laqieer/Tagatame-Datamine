// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RarityParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005E8")]
  public sealed class JSON_RarityParamFormatter : 
    IMessagePackFormatter<JSON_RarityParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001068")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001069")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B06")]
    [Address(RVA = "0xB9AB60", Offset = "0xB99960", VA = "0x10B9AB60")]
    public JSON_RarityParamFormatter()
    {
    }

    [Token(Token = "0x6001B07")]
    [Address(RVA = "0xB99FE0", Offset = "0xB98DE0", VA = "0x10B99FE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RarityParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B08")]
    [Address(RVA = "0xB99230", Offset = "0xB98030", VA = "0x10B99230", Slot = "5")]
    public JSON_RarityParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RarityParam) null;
    }
  }
}
