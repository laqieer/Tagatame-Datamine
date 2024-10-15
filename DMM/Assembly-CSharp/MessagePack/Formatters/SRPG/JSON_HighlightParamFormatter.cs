// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_HighlightParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000650")]
  public sealed class JSON_HighlightParamFormatter : 
    IMessagePackFormatter<JSON_HighlightParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001138")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001139")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C3E")]
    [Address(RVA = "0xBD9B30", Offset = "0xBD8930", VA = "0x10BD9B30")]
    public JSON_HighlightParamFormatter()
    {
    }

    [Token(Token = "0x6001C3F")]
    [Address(RVA = "0xBD97D0", Offset = "0xBD85D0", VA = "0x10BD97D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_HighlightParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C40")]
    [Address(RVA = "0xBD9340", Offset = "0xBD8140", VA = "0x10BD9340", Slot = "5")]
    public JSON_HighlightParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_HighlightParam) null;
    }
  }
}
