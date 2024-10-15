// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePridePanelParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200092D")]
  public sealed class RunePridePanelParamFormatter : 
    IMessagePackFormatter<RunePridePanelParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016EA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016EB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024D5")]
    [Address(RVA = "0xE08550", Offset = "0xE07350", VA = "0x10E08550")]
    public RunePridePanelParamFormatter()
    {
    }

    [Token(Token = "0x60024D6")]
    [Address(RVA = "0xE082B0", Offset = "0xE070B0", VA = "0x10E082B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePridePanelParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024D7")]
    [Address(RVA = "0xE07F70", Offset = "0xE06D70", VA = "0x10E07F70", Slot = "5")]
    public RunePridePanelParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePridePanelParam) null;
    }
  }
}
