// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeAbilChg_DataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000745")]
  public sealed class MultiPlayResumeAbilChg_DataFormatter : 
    IMessagePackFormatter<MultiPlayResumeAbilChg.Data>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001322")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001323")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F1D")]
    [Address(RVA = "0xC88B20", Offset = "0xC87920", VA = "0x10C88B20")]
    public MultiPlayResumeAbilChg_DataFormatter()
    {
    }

    [Token(Token = "0x6001F1E")]
    [Address(RVA = "0xC888F0", Offset = "0xC876F0", VA = "0x10C888F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeAbilChg.Data value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F1F")]
    [Address(RVA = "0xC884E0", Offset = "0xC872E0", VA = "0x10C884E0", Slot = "5")]
    public MultiPlayResumeAbilChg.Data Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeAbilChg.Data) null;
    }
  }
}
