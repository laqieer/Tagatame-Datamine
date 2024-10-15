// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000722")]
  public sealed class JSON_AdventureDataFormatter : 
    IMessagePackFormatter<JSON_AdventureData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012DC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012DD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EB4")]
    [Address(RVA = "0xC53A40", Offset = "0xC52840", VA = "0x10C53A40")]
    public JSON_AdventureDataFormatter()
    {
    }

    [Token(Token = "0x6001EB5")]
    [Address(RVA = "0xC53800", Offset = "0xC52600", VA = "0x10C53800", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EB6")]
    [Address(RVA = "0xC533F0", Offset = "0xC521F0", VA = "0x10C533F0", Slot = "5")]
    public JSON_AdventureData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureData) null;
    }
  }
}
