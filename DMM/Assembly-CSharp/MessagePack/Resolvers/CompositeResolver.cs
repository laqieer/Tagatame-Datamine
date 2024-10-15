// Decompiled with JetBrains decompiler
// Type: MessagePack.Resolvers.CompositeResolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;

#nullable disable
namespace MessagePack.Resolvers
{
  [Token(Token = "0x200038C")]
  public sealed class CompositeResolver : IFormatterResolver
  {
    [Token(Token = "0x4000DE8")]
    [FieldOffset(Offset = "0x0")]
    public static readonly CompositeResolver Instance;
    [Token(Token = "0x4000DE9")]
    [FieldOffset(Offset = "0x4")]
    private static bool isFreezed;
    [Token(Token = "0x4000DEA")]
    [FieldOffset(Offset = "0x8")]
    private static IMessagePackFormatter[] formatters;
    [Token(Token = "0x4000DEB")]
    [FieldOffset(Offset = "0xC")]
    private static IFormatterResolver[] resolvers;

    [Token(Token = "0x600131D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private CompositeResolver()
    {
    }

    [Token(Token = "0x600131E")]
    [Address(RVA = "0x4B8290", Offset = "0x4B7090", VA = "0x104B8290")]
    public static void Register(params IFormatterResolver[] resolvers)
    {
    }

    [Token(Token = "0x600131F")]
    [Address(RVA = "0x4B81C0", Offset = "0x4B6FC0", VA = "0x104B81C0")]
    public static void Register(params IMessagePackFormatter[] formatters)
    {
    }

    [Token(Token = "0x6001320")]
    [Address(RVA = "0x4B80D0", Offset = "0x4B6ED0", VA = "0x104B80D0")]
    public static void Register(IMessagePackFormatter[] formatters, IFormatterResolver[] resolvers)
    {
    }

    [Token(Token = "0x6001321")]
    [Address(RVA = "0x4B7EF0", Offset = "0x4B6CF0", VA = "0x104B7EF0")]
    public static void RegisterAndSetAsDefault(params IFormatterResolver[] resolvers)
    {
    }

    [Token(Token = "0x6001322")]
    [Address(RVA = "0x4B8040", Offset = "0x4B6E40", VA = "0x104B8040")]
    public static void RegisterAndSetAsDefault(params IMessagePackFormatter[] formatters)
    {
    }

    [Token(Token = "0x6001323")]
    [Address(RVA = "0x4B7FA0", Offset = "0x4B6DA0", VA = "0x104B7FA0")]
    public static void RegisterAndSetAsDefault(
      IMessagePackFormatter[] formatters,
      IFormatterResolver[] resolvers)
    {
    }

    [Token(Token = "0x6001324")]
    public IMessagePackFormatter<T> GetFormatter<T>() => (IMessagePackFormatter<T>) null;

    [Token(Token = "0x6001325")]
    [Address(RVA = "0x4B8360", Offset = "0x4B7160", VA = "0x104B8360")]
    static CompositeResolver()
    {
    }

    [Token(Token = "0x200038D")]
    private static class FormatterCache<T>
    {
      [Token(Token = "0x4000DEC")]
      [FieldOffset(Offset = "0x0")]
      public static readonly IMessagePackFormatter<T> formatter;

      [Token(Token = "0x6001326")]
      static FormatterCache()
      {
      }
    }
  }
}
