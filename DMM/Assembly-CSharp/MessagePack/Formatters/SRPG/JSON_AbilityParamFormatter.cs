// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AbilityParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005DD")]
  public sealed class JSON_AbilityParamFormatter : 
    IMessagePackFormatter<JSON_AbilityParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001052")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001053")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AE5")]
    [Address(RVA = "0xB36820", Offset = "0xB35620", VA = "0x10B36820")]
    public JSON_AbilityParamFormatter()
    {
    }

    [Token(Token = "0x6001AE6")]
    [Address(RVA = "0xB35C80", Offset = "0xB34A80", VA = "0x10B35C80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AbilityParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AE7")]
    [Address(RVA = "0xB34F30", Offset = "0xB33D30", VA = "0x10B34F30", Slot = "5")]
    public JSON_AbilityParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AbilityParam) null;
    }
  }
}
