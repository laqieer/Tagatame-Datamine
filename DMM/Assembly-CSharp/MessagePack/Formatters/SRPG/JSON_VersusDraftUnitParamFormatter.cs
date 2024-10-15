// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusDraftUnitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007FF")]
  public sealed class JSON_VersusDraftUnitParamFormatter : 
    IMessagePackFormatter<JSON_VersusDraftUnitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400148E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400148F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600214B")]
    [Address(RVA = "0xD339F0", Offset = "0xD327F0", VA = "0x10D339F0")]
    public JSON_VersusDraftUnitParamFormatter()
    {
    }

    [Token(Token = "0x600214C")]
    [Address(RVA = "0xD32B30", Offset = "0xD31930", VA = "0x10D32B30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusDraftUnitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600214D")]
    [Address(RVA = "0xD319F0", Offset = "0xD307F0", VA = "0x10D319F0", Slot = "5")]
    public JSON_VersusDraftUnitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusDraftUnitParam) null;
    }
  }
}
