// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GenesisChapterModeInfoParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008D6")]
  public sealed class JSON_GenesisChapterModeInfoParamFormatter : 
    IMessagePackFormatter<JSON_GenesisChapterModeInfoParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400163C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400163D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023D0")]
    [Address(RVA = "0xDCE7C0", Offset = "0xDCD5C0", VA = "0x10DCE7C0")]
    public JSON_GenesisChapterModeInfoParamFormatter()
    {
    }

    [Token(Token = "0x60023D1")]
    [Address(RVA = "0xDCE480", Offset = "0xDCD280", VA = "0x10DCE480", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GenesisChapterModeInfoParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023D2")]
    [Address(RVA = "0xDCDF80", Offset = "0xDCCD80", VA = "0x10DCDF80", Slot = "5")]
    public JSON_GenesisChapterModeInfoParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GenesisChapterModeInfoParam) null;
    }
  }
}
