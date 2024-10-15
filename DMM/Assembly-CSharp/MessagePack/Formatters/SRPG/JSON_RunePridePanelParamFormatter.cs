// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePridePanelParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006E0")]
  public sealed class JSON_RunePridePanelParamFormatter : 
    IMessagePackFormatter<JSON_RunePridePanelParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001258")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001259")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DEE")]
    [Address(RVA = "0xC31E00", Offset = "0xC30C00", VA = "0x10C31E00")]
    public JSON_RunePridePanelParamFormatter()
    {
    }

    [Token(Token = "0x6001DEF")]
    [Address(RVA = "0xC31C20", Offset = "0xC30A20", VA = "0x10C31C20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePridePanelParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DF0")]
    [Address(RVA = "0xC31870", Offset = "0xC30670", VA = "0x10C31870", Slot = "5")]
    public JSON_RunePridePanelParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePridePanelParam) null;
    }
  }
}
