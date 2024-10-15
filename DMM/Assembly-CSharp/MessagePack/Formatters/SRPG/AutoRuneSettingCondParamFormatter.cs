// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AutoRuneSettingCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000801")]
  public sealed class AutoRuneSettingCondParamFormatter : 
    IMessagePackFormatter<AutoRuneSettingCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001492")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001493")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002151")]
    [Address(RVA = "0xD3EDE0", Offset = "0xD3DBE0", VA = "0x10D3EDE0")]
    public AutoRuneSettingCondParamFormatter()
    {
    }

    [Token(Token = "0x6002152")]
    [Address(RVA = "0xD3EC20", Offset = "0xD3DA20", VA = "0x10D3EC20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AutoRuneSettingCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002153")]
    [Address(RVA = "0xD3E930", Offset = "0xD3D730", VA = "0x10D3E930", Slot = "5")]
    public AutoRuneSettingCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AutoRuneSettingCondParam) null;
    }
  }
}
