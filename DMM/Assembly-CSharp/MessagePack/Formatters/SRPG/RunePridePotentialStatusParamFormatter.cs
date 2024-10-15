// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePridePotentialStatusParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200093A")]
  public sealed class RunePridePotentialStatusParamFormatter : 
    IMessagePackFormatter<RunePridePotentialStatusParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001704")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001705")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024FC")]
    [Address(RVA = "0xE21140", Offset = "0xE1FF40", VA = "0x10E21140")]
    public RunePridePotentialStatusParamFormatter()
    {
    }

    [Token(Token = "0x60024FD")]
    [Address(RVA = "0xE20F00", Offset = "0xE1FD00", VA = "0x10E20F00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePridePotentialStatusParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024FE")]
    [Address(RVA = "0xE20BF0", Offset = "0xE1F9F0", VA = "0x10E20BF0", Slot = "5")]
    public RunePridePotentialStatusParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePridePotentialStatusParam) null;
    }
  }
}
