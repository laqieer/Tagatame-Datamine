// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.CrystalDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200079B")]
  public sealed class CrystalDataFormatter : 
    IMessagePackFormatter<CrystalData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013CE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013CF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600201F")]
    [Address(RVA = "0xCD86F0", Offset = "0xCD74F0", VA = "0x10CD86F0")]
    public CrystalDataFormatter()
    {
    }

    [Token(Token = "0x6002020")]
    [Address(RVA = "0xCD8230", Offset = "0xCD7030", VA = "0x10CD8230", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      CrystalData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002021")]
    [Address(RVA = "0xCD7E30", Offset = "0xCD6C30", VA = "0x10CD7E30", Slot = "5")]
    public CrystalData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (CrystalData) null;
    }
  }
}
