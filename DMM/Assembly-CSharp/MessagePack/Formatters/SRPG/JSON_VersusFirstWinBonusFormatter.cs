// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusFirstWinBonusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009FD")]
  public sealed class JSON_VersusFirstWinBonusFormatter : 
    IMessagePackFormatter<JSON_VersusFirstWinBonus>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400188A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400188B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002745")]
    [Address(RVA = "0xE85A60", Offset = "0xE84860", VA = "0x10E85A60")]
    public JSON_VersusFirstWinBonusFormatter()
    {
    }

    [Token(Token = "0x6002746")]
    [Address(RVA = "0xE857E0", Offset = "0xE845E0", VA = "0x10E857E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusFirstWinBonus value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002747")]
    [Address(RVA = "0xE85420", Offset = "0xE84220", VA = "0x10E85420", Slot = "5")]
    public JSON_VersusFirstWinBonus Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusFirstWinBonus) null;
    }
  }
}
