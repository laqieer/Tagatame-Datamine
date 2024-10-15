// Decompiled with JetBrains decompiler
// Type: MessagePack.LZ4MessagePackSerializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using System;
using System.IO;
using System.Reflection;
using System.Text;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x2000356")]
  public static class LZ4MessagePackSerializer
  {
    [Token(Token = "0x4000D50")]
    public const sbyte ExtensionTypeCode = 99;
    [Token(Token = "0x4000D51")]
    public const int NotCompressionSize = 64;

    [Token(Token = "0x60011AC")]
    public static byte[] Serialize<T>(T obj) => (byte[]) null;

    [Token(Token = "0x60011AD")]
    public static byte[] Serialize<T>(T obj, IFormatterResolver resolver) => (byte[]) null;

    [Token(Token = "0x60011AE")]
    public static void Serialize<T>(Stream stream, T obj)
    {
    }

    [Token(Token = "0x60011AF")]
    public static void Serialize<T>(Stream stream, T obj, IFormatterResolver resolver)
    {
    }

    [Token(Token = "0x60011B0")]
    public static int SerializeToBlock<T>(
      ref byte[] bytes,
      int offset,
      T obj,
      IFormatterResolver resolver)
    {
      return new int();
    }

    [Token(Token = "0x60011B1")]
    [Address(RVA = "0x2EE910", Offset = "0x2ED710", VA = "0x102EE910")]
    public static byte[] ToLZ4Binary(ArraySegment<byte> messagePackBinary) => (byte[]) null;

    [Token(Token = "0x60011B2")]
    private static ArraySegment<byte> SerializeCore<T>(T obj, IFormatterResolver resolver)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x60011B3")]
    [Address(RVA = "0x2EE740", Offset = "0x2ED540", VA = "0x102EE740")]
    private static ArraySegment<byte> ToLZ4BinaryCore(ArraySegment<byte> serializedData)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x60011B4")]
    public static T Deserialize<T>(byte[] bytes) => (T) null;

    [Token(Token = "0x60011B5")]
    public static T Deserialize<T>(byte[] bytes, IFormatterResolver resolver) => (T) null;

    [Token(Token = "0x60011B6")]
    public static T Deserialize<T>(ArraySegment<byte> bytes) => (T) null;

    [Token(Token = "0x60011B7")]
    public static T Deserialize<T>(ArraySegment<byte> bytes, IFormatterResolver resolver)
    {
      return (T) null;
    }

    [Token(Token = "0x60011B8")]
    public static T Deserialize<T>(Stream stream) => (T) null;

    [Token(Token = "0x60011B9")]
    public static T Deserialize<T>(Stream stream, IFormatterResolver resolver) => (T) null;

    [Token(Token = "0x60011BA")]
    public static T Deserialize<T>(Stream stream, bool readStrict) => (T) null;

    [Token(Token = "0x60011BB")]
    public static T Deserialize<T>(Stream stream, IFormatterResolver resolver, bool readStrict)
    {
      return (T) null;
    }

    [Token(Token = "0x60011BC")]
    [Address(RVA = "0x2ECF00", Offset = "0x2EBD00", VA = "0x102ECF00")]
    public static byte[] Decode(Stream stream, bool readStrict = false) => (byte[]) null;

    [Token(Token = "0x60011BD")]
    [Address(RVA = "0x2ED0A0", Offset = "0x2EBEA0", VA = "0x102ED0A0")]
    public static byte[] Decode(byte[] bytes) => (byte[]) null;

    [Token(Token = "0x60011BE")]
    [Address(RVA = "0x2ED120", Offset = "0x2EBF20", VA = "0x102ED120")]
    public static byte[] Decode(ArraySegment<byte> bytes) => (byte[]) null;

    [Token(Token = "0x60011BF")]
    [Address(RVA = "0x2ECBE0", Offset = "0x2EB9E0", VA = "0x102ECBE0")]
    public static byte[] DecodeUnsafe(byte[] bytes) => (byte[]) null;

    [Token(Token = "0x60011C0")]
    [Address(RVA = "0x2ECC60", Offset = "0x2EBA60", VA = "0x102ECC60")]
    public static byte[] DecodeUnsafe(ArraySegment<byte> bytes) => (byte[]) null;

    [Token(Token = "0x60011C1")]
    private static T DeserializeCore<T>(ArraySegment<byte> bytes, IFormatterResolver resolver)
    {
      return (T) null;
    }

    [Token(Token = "0x60011C2")]
    [Address(RVA = "0x2ED390", Offset = "0x2EC190", VA = "0x102ED390")]
    private static int FillFromStream(Stream input, ref byte[] buffer) => new int();

    [Token(Token = "0x60011C3")]
    public static string ToJson<T>(T obj) => (string) null;

    [Token(Token = "0x60011C4")]
    public static string ToJson<T>(T obj, IFormatterResolver resolver) => (string) null;

    [Token(Token = "0x60011C5")]
    [Address(RVA = "0x2EE560", Offset = "0x2ED360", VA = "0x102EE560")]
    public static string ToJson(byte[] bytes) => (string) null;

    [Token(Token = "0x60011C6")]
    [Address(RVA = "0x2ED5A0", Offset = "0x2EC3A0", VA = "0x102ED5A0")]
    public static byte[] FromJson(string str) => (byte[]) null;

    [Token(Token = "0x60011C7")]
    [Address(RVA = "0x2ED440", Offset = "0x2EC240", VA = "0x102ED440")]
    public static byte[] FromJson(TextReader reader) => (byte[]) null;

    [Token(Token = "0x60011C8")]
    [Address(RVA = "0x2ED810", Offset = "0x2EC610", VA = "0x102ED810")]
    private static int ToJsonCore(byte[] bytes, int offset, StringBuilder builder) => new int();

    [Token(Token = "0x60011C9")]
    [Address(RVA = "0x2EEA60", Offset = "0x2ED860", VA = "0x102EEA60")]
    private static void WriteJsonString(string value, StringBuilder builder)
    {
    }

    [Token(Token = "0x2000357")]
    public static class NonGeneric
    {
      [Token(Token = "0x4000D52")]
      [FieldOffset(Offset = "0x0")]
      private static readonly Func<Type, LZ4MessagePackSerializer.NonGeneric.CompiledMethods> CreateCompiledMethods;
      [Token(Token = "0x4000D53")]
      [FieldOffset(Offset = "0x4")]
      private static readonly ThreadsafeTypeKeyHashTable<LZ4MessagePackSerializer.NonGeneric.CompiledMethods> serializes;

      [Token(Token = "0x60011CA")]
      [Address(RVA = "0x3037D0", Offset = "0x3025D0", VA = "0x103037D0")]
      static NonGeneric()
      {
      }

      [Token(Token = "0x60011CB")]
      [Address(RVA = "0x3036F0", Offset = "0x3024F0", VA = "0x103036F0")]
      public static byte[] Serialize(Type type, object obj) => (byte[]) null;

      [Token(Token = "0x60011CC")]
      [Address(RVA = "0x3033E0", Offset = "0x3021E0", VA = "0x103033E0")]
      public static byte[] Serialize(Type type, object obj, IFormatterResolver resolver)
      {
        return (byte[]) null;
      }

      [Token(Token = "0x60011CD")]
      [Address(RVA = "0x3035A0", Offset = "0x3023A0", VA = "0x103035A0")]
      public static void Serialize(Type type, Stream stream, object obj)
      {
      }

      [Token(Token = "0x60011CE")]
      [Address(RVA = "0x303680", Offset = "0x302480", VA = "0x10303680")]
      public static void Serialize(
        Type type,
        Stream stream,
        object obj,
        IFormatterResolver resolver)
      {
      }

      [Token(Token = "0x60011CF")]
      [Address(RVA = "0x303290", Offset = "0x302090", VA = "0x10303290")]
      public static object Deserialize(Type type, byte[] bytes) => (object) null;

      [Token(Token = "0x60011D0")]
      [Address(RVA = "0x303050", Offset = "0x301E50", VA = "0x10303050")]
      public static object Deserialize(Type type, byte[] bytes, IFormatterResolver resolver)
      {
        return (object) null;
      }

      [Token(Token = "0x60011D1")]
      [Address(RVA = "0x302E90", Offset = "0x301C90", VA = "0x10302E90")]
      public static object Deserialize(Type type, Stream stream) => (object) null;

      [Token(Token = "0x60011D2")]
      [Address(RVA = "0x302B50", Offset = "0x301950", VA = "0x10302B50")]
      public static object Deserialize(Type type, Stream stream, IFormatterResolver resolver)
      {
        return (object) null;
      }

      [Token(Token = "0x60011D3")]
      [Address(RVA = "0x302F70", Offset = "0x301D70", VA = "0x10302F70")]
      public static object Deserialize(Type type, Stream stream, bool readStrict) => (object) null;

      [Token(Token = "0x60011D4")]
      [Address(RVA = "0x302F00", Offset = "0x301D00", VA = "0x10302F00")]
      public static object Deserialize(
        Type type,
        Stream stream,
        IFormatterResolver resolver,
        bool readStrict)
      {
        return (object) null;
      }

      [Token(Token = "0x60011D5")]
      [Address(RVA = "0x302E10", Offset = "0x301C10", VA = "0x10302E10")]
      public static object Deserialize(Type type, ArraySegment<byte> bytes) => (object) null;

      [Token(Token = "0x60011D6")]
      [Address(RVA = "0x3031A0", Offset = "0x301FA0", VA = "0x103031A0")]
      public static object Deserialize(
        Type type,
        ArraySegment<byte> bytes,
        IFormatterResolver resolver)
      {
        return (object) null;
      }

      [Token(Token = "0x60011D7")]
      [Address(RVA = "0x303370", Offset = "0x302170", VA = "0x10303370")]
      private static LZ4MessagePackSerializer.NonGeneric.CompiledMethods GetOrAdd(Type type)
      {
        return (LZ4MessagePackSerializer.NonGeneric.CompiledMethods) null;
      }

      [Token(Token = "0x2000358")]
      private class CompiledMethods
      {
        [Token(Token = "0x4000D54")]
        [FieldOffset(Offset = "0x8")]
        public readonly Func<object, byte[]> serialize1;
        [Token(Token = "0x4000D55")]
        [FieldOffset(Offset = "0xC")]
        public readonly Func<object, IFormatterResolver, byte[]> serialize2;
        [Token(Token = "0x4000D56")]
        [FieldOffset(Offset = "0x10")]
        public readonly Action<Stream, object> serialize3;
        [Token(Token = "0x4000D57")]
        [FieldOffset(Offset = "0x14")]
        public readonly Action<Stream, object, IFormatterResolver> serialize4;
        [Token(Token = "0x4000D58")]
        [FieldOffset(Offset = "0x18")]
        public readonly Func<byte[], object> deserialize1;
        [Token(Token = "0x4000D59")]
        [FieldOffset(Offset = "0x1C")]
        public readonly Func<byte[], IFormatterResolver, object> deserialize2;
        [Token(Token = "0x4000D5A")]
        [FieldOffset(Offset = "0x20")]
        public readonly Func<Stream, object> deserialize3;
        [Token(Token = "0x4000D5B")]
        [FieldOffset(Offset = "0x24")]
        public readonly Func<Stream, IFormatterResolver, object> deserialize4;
        [Token(Token = "0x4000D5C")]
        [FieldOffset(Offset = "0x28")]
        public readonly Func<Stream, bool, object> deserialize5;
        [Token(Token = "0x4000D5D")]
        [FieldOffset(Offset = "0x2C")]
        public readonly Func<Stream, IFormatterResolver, bool, object> deserialize6;
        [Token(Token = "0x4000D5E")]
        [FieldOffset(Offset = "0x30")]
        public readonly Func<ArraySegment<byte>, object> deserialize7;
        [Token(Token = "0x4000D5F")]
        [FieldOffset(Offset = "0x34")]
        public readonly Func<ArraySegment<byte>, IFormatterResolver, object> deserialize8;

        [Token(Token = "0x60011D8")]
        [Address(RVA = "0x2EADA0", Offset = "0x2E9BA0", VA = "0x102EADA0")]
        public CompiledMethods(Type type)
        {
        }

        [Token(Token = "0x60011D9")]
        [Address(RVA = "0x2E89E0", Offset = "0x2E77E0", VA = "0x102E89E0")]
        private static MethodInfo GetMethod(Type type, Type[] parameters) => (MethodInfo) null;
      }
    }
  }
}
