// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.ExpressionUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Linq.Expressions;
using System.Reflection;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x2000469")]
  public static class ExpressionUtility
  {
    [Token(Token = "0x60015B5")]
    [Address(RVA = "0x5BDDE0", Offset = "0x5BCBE0", VA = "0x105BDDE0")]
    private static MethodInfo GetMethodInfoCore(LambdaExpression expression) => (MethodInfo) null;

    [Token(Token = "0x60015B6")]
    public static MethodInfo GetMethodInfo<T>(Expression<Func<T>> expression) => (MethodInfo) null;

    [Token(Token = "0x60015B7")]
    [Address(RVA = "0x5BDDE0", Offset = "0x5BCBE0", VA = "0x105BDDE0")]
    public static MethodInfo GetMethodInfo(Expression<Action> expression) => (MethodInfo) null;

    [Token(Token = "0x60015B8")]
    public static MethodInfo GetMethodInfo<T, TR>(Expression<Func<T, TR>> expression)
    {
      return (MethodInfo) null;
    }

    [Token(Token = "0x60015B9")]
    public static MethodInfo GetMethodInfo<T>(Expression<Action<T>> expression)
    {
      return (MethodInfo) null;
    }

    [Token(Token = "0x60015BA")]
    public static MethodInfo GetMethodInfo<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> expression)
    {
      return (MethodInfo) null;
    }

    [Token(Token = "0x60015BB")]
    private static MemberInfo GetMemberInfoCore<T>(Expression<T> source) => (MemberInfo) null;

    [Token(Token = "0x60015BC")]
    public static PropertyInfo GetPropertyInfo<T, TR>(Expression<Func<T, TR>> expression)
    {
      return (PropertyInfo) null;
    }

    [Token(Token = "0x60015BD")]
    public static FieldInfo GetFieldInfo<T, TR>(Expression<Func<T, TR>> expression)
    {
      return (FieldInfo) null;
    }
  }
}
