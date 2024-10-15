// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.UnitDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007A1")]
  public sealed class UnitDataFormatter : IMessagePackFormatter<UnitData>, IMessagePackFormatter
  {
    [Token(Token = "0x40013DA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013DB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002031")]
    [Address(RVA = "0xCE7720", Offset = "0xCE6520", VA = "0x10CE7720")]
    public UnitDataFormatter()
    {
    }

    [Token(Token = "0x6002032")]
    [Address(RVA = "0xCE5220", Offset = "0xCE4020", VA = "0x10CE5220", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      UnitData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002033")]
    [Address(RVA = "0xCE42C0", Offset = "0xCE30C0", VA = "0x10CE42C0", Slot = "5")]
    public UnitData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (UnitData) null;
    }
  }
}
