// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_VersusCountFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008A0")]
  public sealed class Json_VersusCountFormatter : 
    IMessagePackFormatter<Json_VersusCount>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015D0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015D1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600232E")]
    [Address(RVA = "0xDC1E30", Offset = "0xDC0C30", VA = "0x10DC1E30")]
    public Json_VersusCountFormatter()
    {
    }

    [Token(Token = "0x600232F")]
    [Address(RVA = "0xDC1CD0", Offset = "0xDC0AD0", VA = "0x10DC1CD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_VersusCount value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002330")]
    [Address(RVA = "0xDC1980", Offset = "0xDC0780", VA = "0x10DC1980", Slot = "5")]
    public Json_VersusCount Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_VersusCount) null;
    }
  }
}
