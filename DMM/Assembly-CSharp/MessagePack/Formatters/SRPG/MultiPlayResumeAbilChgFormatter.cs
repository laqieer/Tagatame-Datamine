// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeAbilChgFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000746")]
  public sealed class MultiPlayResumeAbilChgFormatter : 
    IMessagePackFormatter<MultiPlayResumeAbilChg>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001324")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001325")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F20")]
    [Address(RVA = "0xC883C0", Offset = "0xC871C0", VA = "0x10C883C0")]
    public MultiPlayResumeAbilChgFormatter()
    {
    }

    [Token(Token = "0x6001F21")]
    [Address(RVA = "0xC88250", Offset = "0xC87050", VA = "0x10C88250", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeAbilChg value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F22")]
    [Address(RVA = "0xC87F80", Offset = "0xC86D80", VA = "0x10C87F80", Slot = "5")]
    public MultiPlayResumeAbilChg Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeAbilChg) null;
    }
  }
}
