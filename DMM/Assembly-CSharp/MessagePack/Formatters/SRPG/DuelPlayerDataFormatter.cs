// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.DuelPlayerDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A05")]
  public sealed class DuelPlayerDataFormatter : 
    IMessagePackFormatter<DuelPlayerData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400189A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400189B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600275D")]
    [Address(RVA = "0xE95130", Offset = "0xE93F30", VA = "0x10E95130")]
    public DuelPlayerDataFormatter()
    {
    }

    [Token(Token = "0x600275E")]
    [Address(RVA = "0xE94A10", Offset = "0xE93810", VA = "0x10E94A10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DuelPlayerData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600275F")]
    [Address(RVA = "0xE94520", Offset = "0xE93320", VA = "0x10E94520", Slot = "5")]
    public DuelPlayerData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (DuelPlayerData) null;
    }
  }
}
