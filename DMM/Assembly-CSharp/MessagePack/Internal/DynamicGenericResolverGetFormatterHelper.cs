// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.DynamicGenericResolverGetFormatterHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x2000478")]
  internal static class DynamicGenericResolverGetFormatterHelper
  {
    [Token(Token = "0x4000F28")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<Type, Type> formatterMap;

    [Token(Token = "0x600163B")]
    [Address(RVA = "0x698730", Offset = "0x697530", VA = "0x10698730")]
    internal static object GetFormatter(Type t) => (object) null;

    [Token(Token = "0x600163C")]
    [Address(RVA = "0x6986F0", Offset = "0x6974F0", VA = "0x106986F0")]
    private static object CreateInstance(
      Type genericType,
      Type[] genericTypeArguments,
      params object[] arguments)
    {
      return (object) null;
    }

    [Token(Token = "0x600163D")]
    [Address(RVA = "0x699CE0", Offset = "0x698AE0", VA = "0x10699CE0")]
    static DynamicGenericResolverGetFormatterHelper()
    {
    }
  }
}
