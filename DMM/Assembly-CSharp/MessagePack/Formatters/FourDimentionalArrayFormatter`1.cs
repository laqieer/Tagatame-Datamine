// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.FourDimentionalArrayFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004D3")]
  public sealed class FourDimentionalArrayFormatter<T> : 
    IMessagePackFormatter<T[,,,]>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F63")]
    private const int ArrayLength = 5;

    [Token(Token = "0x600177F")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      T[,,,] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001780")]
    public T[,,,] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (T[,,,]) null;
    }

    [Token(Token = "0x6001781")]
    public FourDimentionalArrayFormatter()
    {
    }
  }
}
