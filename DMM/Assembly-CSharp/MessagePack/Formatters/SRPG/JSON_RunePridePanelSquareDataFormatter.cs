// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePridePanelSquareDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006E2")]
  public sealed class JSON_RunePridePanelSquareDataFormatter : 
    IMessagePackFormatter<JSON_RunePridePanelSquareData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400125C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400125D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DF4")]
    [Address(RVA = "0xC330E0", Offset = "0xC31EE0", VA = "0x10C330E0")]
    public JSON_RunePridePanelSquareDataFormatter()
    {
    }

    [Token(Token = "0x6001DF5")]
    [Address(RVA = "0xC32CA0", Offset = "0xC31AA0", VA = "0x10C32CA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePridePanelSquareData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DF6")]
    [Address(RVA = "0xC32680", Offset = "0xC31480", VA = "0x10C32680", Slot = "5")]
    public JSON_RunePridePanelSquareData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePridePanelSquareData) null;
    }
  }
}
