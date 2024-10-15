// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePridePanelSquareDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200095F")]
  public sealed class RunePridePanelSquareDataFormatter : 
    IMessagePackFormatter<RunePridePanelSquareData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400174E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400174F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600256B")]
    [Address(RVA = "0xE20560", Offset = "0xE1F360", VA = "0x10E20560")]
    public RunePridePanelSquareDataFormatter()
    {
    }

    [Token(Token = "0x600256C")]
    [Address(RVA = "0xE1FF60", Offset = "0xE1ED60", VA = "0x10E1FF60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePridePanelSquareData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600256D")]
    [Address(RVA = "0xE1FB40", Offset = "0xE1E940", VA = "0x10E1FB40", Slot = "5")]
    public RunePridePanelSquareData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePridePanelSquareData) null;
    }
  }
}
