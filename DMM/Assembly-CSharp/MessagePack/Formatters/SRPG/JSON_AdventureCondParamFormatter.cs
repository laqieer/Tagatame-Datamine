// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A8D")]
  public sealed class JSON_AdventureCondParamFormatter : 
    IMessagePackFormatter<JSON_AdventureCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019AA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019AB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028F5")]
    [Address(RVA = "0xED7D80", Offset = "0xED6B80", VA = "0x10ED7D80")]
    public JSON_AdventureCondParamFormatter()
    {
    }

    [Token(Token = "0x60028F6")]
    [Address(RVA = "0xED7BA0", Offset = "0xED69A0", VA = "0x10ED7BA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028F7")]
    [Address(RVA = "0xED7860", Offset = "0xED6660", VA = "0x10ED7860", Slot = "5")]
    public JSON_AdventureCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureCondParam) null;
    }
  }
}
