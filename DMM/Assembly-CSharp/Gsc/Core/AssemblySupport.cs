// Decompiled with JetBrains decompiler
// Type: Gsc.Core.AssemblySupport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Reflection;

#nullable disable
namespace Gsc.Core
{
  [Token(Token = "0x20035DF")]
  public static class AssemblySupport
  {
    [Token(Token = "0x600F00B")]
    public static T CreateInstance<T>() => (T) null;

    [Token(Token = "0x600F00C")]
    public static T CreateInstance<T>(params object[] args) => (T) null;

    [Token(Token = "0x600F00D")]
    public static T CreateInstance<T>(string typeName) => (T) null;

    [Token(Token = "0x600F00E")]
    public static T CreateInstance<T>(string typeName, params object[] args) => (T) null;

    [Token(Token = "0x600F00F")]
    public static T CreateInstance<T>(Type type) => (T) null;

    [Token(Token = "0x600F010")]
    public static T CreateInstance<T>(Type type, params object[] args) => (T) null;

    [Token(Token = "0x600F011")]
    [Address(RVA = "0xB014E0", Offset = "0xB002E0", VA = "0x10B014E0")]
    public static Type GetType(string typeName) => (Type) null;

    [Token(Token = "0x600F012")]
    [Address(RVA = "0xB01350", Offset = "0xB00150", VA = "0x10B01350")]
    public static AssemblySupport.MethodInfo GetConstructor(string typeName, params Type[] types)
    {
      return (AssemblySupport.MethodInfo) null;
    }

    [Token(Token = "0x600F013")]
    [Address(RVA = "0xB01450", Offset = "0xB00250", VA = "0x10B01450")]
    public static AssemblySupport.MethodInfo GetMethod(
      string typeName,
      string methodName,
      params Type[] types)
    {
      return (AssemblySupport.MethodInfo) null;
    }

    [Token(Token = "0x600F014")]
    [Address(RVA = "0xB012D0", Offset = "0xB000D0", VA = "0x10B012D0")]
    public static AssemblySupport.MethodInfo GetConstructor(Type type, params Type[] types)
    {
      return (AssemblySupport.MethodInfo) null;
    }

    [Token(Token = "0x600F015")]
    [Address(RVA = "0xB013D0", Offset = "0xB001D0", VA = "0x10B013D0")]
    public static AssemblySupport.MethodInfo GetMethod(
      Type type,
      string methodName,
      params Type[] types)
    {
      return (AssemblySupport.MethodInfo) null;
    }

    [Token(Token = "0x20035E0")]
    public class MethodInfo
    {
      [Token(Token = "0x400FE11")]
      [FieldOffset(Offset = "0x8")]
      public readonly Type Type;
      [Token(Token = "0x400FE12")]
      [FieldOffset(Offset = "0xC")]
      private MethodBase methodInfo;

      [Token(Token = "0x600F016")]
      [Address(RVA = "0xB0CC00", Offset = "0xB0BA00", VA = "0x10B0CC00")]
      public static AssemblySupport.MethodInfo Create(Type type, MethodBase methodInfo)
      {
        return (AssemblySupport.MethodInfo) null;
      }

      [Token(Token = "0x600F017")]
      [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
      private MethodInfo(Type type, MethodBase methodInfo)
      {
      }

      [Token(Token = "0x600F018")]
      [Address(RVA = "0xB0CBD0", Offset = "0xB0B9D0", VA = "0x10B0CBD0")]
      public void CallVoidMethod(object obj, params object[] args)
      {
      }

      [Token(Token = "0x600F019")]
      public T CallMethod<T>(object obj, params object[] args) => (T) null;

      [Token(Token = "0x600F01A")]
      [Address(RVA = "0xB0CBA0", Offset = "0xB0B9A0", VA = "0x10B0CBA0")]
      public void CallStaticVoidMethod(params object[] args)
      {
      }

      [Token(Token = "0x600F01B")]
      public T CallStaticMethod<T>(params object[] args) => (T) null;

      [Token(Token = "0x600F01C")]
      public T CreateInstance<T>(params object[] args) => (T) null;
    }
  }
}
