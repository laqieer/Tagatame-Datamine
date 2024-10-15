// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusTowerParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000729")]
  public sealed class JSON_VersusTowerParamFormatter : 
    IMessagePackFormatter<JSON_VersusTowerParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012EA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012EB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EC9")]
    [Address(RVA = "0xC5C360", Offset = "0xC5B160", VA = "0x10C5C360")]
    public JSON_VersusTowerParamFormatter()
    {
    }

    [Token(Token = "0x6001ECA")]
    [Address(RVA = "0xC5BBF0", Offset = "0xC5A9F0", VA = "0x10C5BBF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusTowerParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001ECB")]
    [Address(RVA = "0xC5B340", Offset = "0xC5A140", VA = "0x10C5B340", Slot = "5")]
    public JSON_VersusTowerParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusTowerParam) null;
    }
  }
}
