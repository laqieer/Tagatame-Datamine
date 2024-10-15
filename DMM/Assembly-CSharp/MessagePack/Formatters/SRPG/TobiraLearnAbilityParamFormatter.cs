// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TobiraLearnAbilityParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000794")]
  public sealed class TobiraLearnAbilityParamFormatter : 
    IMessagePackFormatter<TobiraLearnAbilityParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013C0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013C1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600200A")]
    [Address(RVA = "0xCE2E10", Offset = "0xCE1C10", VA = "0x10CE2E10")]
    public TobiraLearnAbilityParamFormatter()
    {
    }

    [Token(Token = "0x600200B")]
    [Address(RVA = "0xCE2BC0", Offset = "0xCE19C0", VA = "0x10CE2BC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TobiraLearnAbilityParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600200C")]
    [Address(RVA = "0xCE2880", Offset = "0xCE1680", VA = "0x10CE2880", Slot = "5")]
    public TobiraLearnAbilityParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TobiraLearnAbilityParam) null;
    }
  }
}
