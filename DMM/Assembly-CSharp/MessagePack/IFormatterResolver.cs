// Decompiled with JetBrains decompiler
// Type: MessagePack.IFormatterResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x200034E")]
  public interface IFormatterResolver
  {
    [Token(Token = "0x600118D")]
    IMessagePackFormatter<T> GetFormatter<T>();
  }
}
