// Decompiled with JetBrains decompiler
// Type: MessagePack.FormatterResolverExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using System;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x200034F")]
  public static class FormatterResolverExtensions
  {
    [Token(Token = "0x600118E")]
    public static IMessagePackFormatter<T> GetFormatterWithVerify<T>(
      this IFormatterResolver resolver)
    {
      return (IMessagePackFormatter<T>) null;
    }

    [Token(Token = "0x600118F")]
    [Address(RVA = "0x2ECA00", Offset = "0x2EB800", VA = "0x102ECA00")]
    public static object GetFormatterDynamic(this IFormatterResolver resolver, Type type)
    {
      return (object) null;
    }
  }
}
