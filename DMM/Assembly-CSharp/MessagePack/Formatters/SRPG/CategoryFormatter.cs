// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.CategoryFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200056E")]
  public sealed class CategoryFormatter : 
    IMessagePackFormatter<TobiraParam.Category>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001998")]
    [Address(RVA = "0x696B80", Offset = "0x695980", VA = "0x10696B80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TobiraParam.Category value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001999")]
    [Address(RVA = "0x696B30", Offset = "0x695930", VA = "0x10696B30", Slot = "5")]
    public TobiraParam.Category Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new TobiraParam.Category();
    }

    [Token(Token = "0x600199A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CategoryFormatter()
    {
    }
  }
}
