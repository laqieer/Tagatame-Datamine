// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePridePanelContentsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000960")]
  public sealed class RunePridePanelContentsParamFormatter : 
    IMessagePackFormatter<RunePridePanelContentsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001750")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001751")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600256E")]
    [Address(RVA = "0xE1F9C0", Offset = "0xE1E7C0", VA = "0x10E1F9C0")]
    public RunePridePanelContentsParamFormatter()
    {
    }

    [Token(Token = "0x600256F")]
    [Address(RVA = "0xE1F7E0", Offset = "0xE1E5E0", VA = "0x10E1F7E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePridePanelContentsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002570")]
    [Address(RVA = "0xE1F4D0", Offset = "0xE1E2D0", VA = "0x10E1F4D0", Slot = "5")]
    public RunePridePanelContentsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePridePanelContentsParam) null;
    }
  }
}
