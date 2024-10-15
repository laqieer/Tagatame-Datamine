// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AbilityParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200078D")]
  public sealed class AbilityParamFormatter : 
    IMessagePackFormatter<AbilityParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013B2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013B3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FF5")]
    [Address(RVA = "0xCD4C90", Offset = "0xCD3A90", VA = "0x10CD4C90")]
    public AbilityParamFormatter()
    {
    }

    [Token(Token = "0x6001FF6")]
    [Address(RVA = "0xCD4390", Offset = "0xCD3190", VA = "0x10CD4390", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AbilityParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FF7")]
    [Address(RVA = "0xCD3A30", Offset = "0xCD2830", VA = "0x10CD3A30", Slot = "5")]
    public AbilityParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AbilityParam) null;
    }
  }
}
