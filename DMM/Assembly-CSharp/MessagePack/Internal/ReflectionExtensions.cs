// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.ReflectionExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Reflection;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x200046D")]
  internal static class ReflectionExtensions
  {
    [Token(Token = "0x60015E0")]
    [Address(RVA = "0x5CA1A0", Offset = "0x5C8FA0", VA = "0x105CA1A0")]
    public static bool IsNullable(this TypeInfo type) => new bool();

    [Token(Token = "0x60015E1")]
    [Address(RVA = "0x5CA240", Offset = "0x5C9040", VA = "0x105CA240")]
    public static bool IsPublic(this TypeInfo type) => new bool();

    [Token(Token = "0x60015E2")]
    [Address(RVA = "0x5CA000", Offset = "0x5C8E00", VA = "0x105CA000")]
    public static bool IsAnonymous(this TypeInfo type) => new bool();

    [Token(Token = "0x60015E3")]
    [Address(RVA = "0x5CA170", Offset = "0x5C8F70", VA = "0x105CA170")]
    public static bool IsIndexer(this PropertyInfo propertyInfo) => new bool();

    [Token(Token = "0x60015E4")]
    [Address(RVA = "0x5CA130", Offset = "0x5C8F30", VA = "0x105CA130")]
    public static bool IsConstructedGenericType(this TypeInfo type) => new bool();

    [Token(Token = "0x60015E5")]
    [Address(RVA = "0x5C9FA0", Offset = "0x5C8DA0", VA = "0x105C9FA0")]
    public static MethodInfo GetGetMethod(this PropertyInfo propInfo) => (MethodInfo) null;

    [Token(Token = "0x60015E6")]
    [Address(RVA = "0x5C9FD0", Offset = "0x5C8DD0", VA = "0x105C9FD0")]
    public static MethodInfo GetSetMethod(this PropertyInfo propInfo) => (MethodInfo) null;
  }
}
