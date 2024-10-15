// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AdventureDataBaseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000798")]
  public sealed class AdventureDataBaseFormatter : 
    IMessagePackFormatter<AdventureDataBase>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013C8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013C9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002016")]
    [Address(RVA = "0xCD5940", Offset = "0xCD4740", VA = "0x10CD5940")]
    public AdventureDataBaseFormatter()
    {
    }

    [Token(Token = "0x6002017")]
    [Address(RVA = "0xCD5810", Offset = "0xCD4610", VA = "0x10CD5810", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AdventureDataBase value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002018")]
    [Address(RVA = "0xCD5530", Offset = "0xCD4330", VA = "0x10CD5530", Slot = "5")]
    public AdventureDataBase Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AdventureDataBase) null;
    }
  }
}
