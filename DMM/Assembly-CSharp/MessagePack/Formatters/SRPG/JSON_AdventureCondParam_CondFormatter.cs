// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureCondParam_CondFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A8C")]
  public sealed class JSON_AdventureCondParam_CondFormatter : 
    IMessagePackFormatter<JSON_AdventureCondParam.Cond>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019A8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019A9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028F2")]
    [Address(RVA = "0xED8730", Offset = "0xED7530", VA = "0x10ED8730")]
    public JSON_AdventureCondParam_CondFormatter()
    {
    }

    [Token(Token = "0x60028F3")]
    [Address(RVA = "0xED8400", Offset = "0xED7200", VA = "0x10ED8400", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureCondParam.Cond value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028F4")]
    [Address(RVA = "0xED7F00", Offset = "0xED6D00", VA = "0x10ED7F00", Slot = "5")]
    public JSON_AdventureCondParam.Cond Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureCondParam.Cond) null;
    }
  }
}
