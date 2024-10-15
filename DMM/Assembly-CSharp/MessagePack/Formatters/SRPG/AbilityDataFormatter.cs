// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AbilityDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007A6")]
  public sealed class AbilityDataFormatter : 
    IMessagePackFormatter<AbilityData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013E0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013E1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002040")]
    [Address(RVA = "0xCEC550", Offset = "0xCEB350", VA = "0x10CEC550")]
    public AbilityDataFormatter()
    {
    }

    [Token(Token = "0x6002041")]
    [Address(RVA = "0xCEBBA0", Offset = "0xCEA9A0", VA = "0x10CEBBA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AbilityData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002042")]
    [Address(RVA = "0xCEB560", Offset = "0xCEA360", VA = "0x10CEB560", Slot = "5")]
    public AbilityData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AbilityData) null;
    }
  }
}
