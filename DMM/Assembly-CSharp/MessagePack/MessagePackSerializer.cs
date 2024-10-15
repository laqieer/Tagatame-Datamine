// Decompiled with JetBrains decompiler
// Type: MessagePack.MessagePackSerializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x2000363")]
  public static class MessagePackSerializer
  {
    [Token(Token = "0x4000DBD")]
    [FieldOffset(Offset = "0x0")]
    private static IFormatterResolver defaultResolver;

    [Token(Token = "0x17000205")]
    public static IFormatterResolver DefaultResolver
    {
      [Token(Token = "0x6001280"), Address(RVA = "0x302AA0", Offset = "0x3018A0", VA = "0x10302AA0")] get
      {
        return (IFormatterResolver) null;
      }
    }

    [Token(Token = "0x17000206")]
    public static bool IsInitialized
    {
      [Token(Token = "0x6001281"), Address(RVA = "0x302B20", Offset = "0x301920", VA = "0x10302B20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6001282")]
    [Address(RVA = "0x3019D0", Offset = "0x3007D0", VA = "0x103019D0")]
    public static void SetDefaultResolver(IFormatterResolver resolver)
    {
    }

    [Token(Token = "0x6001283")]
    public static byte[] Serialize<T>(T obj) => (byte[]) null;

    [Token(Token = "0x6001284")]
    public static byte[] Serialize<T>(T obj, IFormatterResolver resolver) => (byte[]) null;

    [Token(Token = "0x6001285")]
    public static ArraySegment<byte> SerializeUnsafe<T>(T obj) => new ArraySegment<byte>();

    [Token(Token = "0x6001286")]
    public static ArraySegment<byte> SerializeUnsafe<T>(T obj, IFormatterResolver resolver)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x6001287")]
    public static void Serialize<T>(Stream stream, T obj)
    {
    }

    [Token(Token = "0x6001288")]
    public static void Serialize<T>(Stream stream, T obj, IFormatterResolver resolver)
    {
    }

    [Token(Token = "0x6001289")]
    public static int Serialize<T>(
      ref byte[] bytes,
      int offset,
      T value,
      IFormatterResolver resolver)
    {
      return new int();
    }

    [Token(Token = "0x600128A")]
    public static Task SerializeAsync<T>(Stream stream, T obj) => (Task) null;

    [Token(Token = "0x600128B")]
    public static Task SerializeAsync<T>(Stream stream, T obj, IFormatterResolver resolver)
    {
      return (Task) null;
    }

    [Token(Token = "0x600128C")]
    public static T Deserialize<T>(byte[] bytes) => (T) null;

    [Token(Token = "0x600128D")]
    public static T Deserialize<T>(byte[] bytes, IFormatterResolver resolver) => (T) null;

    [Token(Token = "0x600128E")]
    public static T Deserialize<T>(ArraySegment<byte> bytes) => (T) null;

    [Token(Token = "0x600128F")]
    public static T Deserialize<T>(ArraySegment<byte> bytes, IFormatterResolver resolver)
    {
      return (T) null;
    }

    [Token(Token = "0x6001290")]
    public static T Deserialize<T>(Stream stream) => (T) null;

    [Token(Token = "0x6001291")]
    public static T Deserialize<T>(Stream stream, IFormatterResolver resolver) => (T) null;

    [Token(Token = "0x6001292")]
    public static T Deserialize<T>(Stream stream, bool readStrict) => (T) null;

    [Token(Token = "0x6001293")]
    public static T Deserialize<T>(Stream stream, IFormatterResolver resolver, bool readStrict)
    {
      return (T) null;
    }

    [Token(Token = "0x6001294")]
    public static T Deserialize<T>(
      byte[] bytes,
      int offset,
      IFormatterResolver resolver,
      out int readSize)
    {
      return (T) null;
    }

    [Token(Token = "0x6001295")]
    public static Task<T> DeserializeAsync<T>(Stream stream) => (Task<T>) null;

    [Token(Token = "0x6001296")]
    public static Task<T> DeserializeAsync<T>(Stream stream, IFormatterResolver resolver)
    {
      return (Task<T>) null;
    }

    [Token(Token = "0x6001297")]
    [Address(RVA = "0x3011B0", Offset = "0x2FFFB0", VA = "0x103011B0")]
    private static int FillFromStream(Stream input, ref byte[] buffer) => new int();

    [Token(Token = "0x6001298")]
    public static string ToJson<T>(T obj) => (string) null;

    [Token(Token = "0x6001299")]
    public static string ToJson<T>(T obj, IFormatterResolver resolver) => (string) null;

    [Token(Token = "0x600129A")]
    [Address(RVA = "0x3028A0", Offset = "0x3016A0", VA = "0x103028A0")]
    public static string ToJson(byte[] bytes) => (string) null;

    [Token(Token = "0x600129B")]
    [Address(RVA = "0x3018A0", Offset = "0x3006A0", VA = "0x103018A0")]
    public static byte[] FromJson(string str) => (byte[]) null;

    [Token(Token = "0x600129C")]
    [Address(RVA = "0x301730", Offset = "0x300530", VA = "0x10301730")]
    public static byte[] FromJson(TextReader reader) => (byte[]) null;

    [Token(Token = "0x600129D")]
    [Address(RVA = "0x3015C0", Offset = "0x3003C0", VA = "0x103015C0")]
    internal static ArraySegment<byte> FromJsonUnsafe(TextReader reader)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x600129E")]
    [Address(RVA = "0x301260", Offset = "0x300060", VA = "0x10301260")]
    private static uint FromJsonCore(TinyJsonReader jr, ref byte[] binary, ref int offset)
    {
      return new uint();
    }

    [Token(Token = "0x600129F")]
    [Address(RVA = "0x301A10", Offset = "0x300810", VA = "0x10301A10")]
    private static int ToJsonCore(byte[] bytes, int offset, StringBuilder builder) => new int();

    [Token(Token = "0x60012A0")]
    [Address(RVA = "0x302930", Offset = "0x301730", VA = "0x10302930")]
    private static void WriteJsonString(string value, StringBuilder builder)
    {
    }

    [Token(Token = "0x2000364")]
    public static class NonGeneric
    {
      [Token(Token = "0x4000DBE")]
      [FieldOffset(Offset = "0x0")]
      private static readonly Func<Type, MessagePackSerializer.NonGeneric.CompiledMethods> CreateCompiledMethods;
      [Token(Token = "0x4000DBF")]
      [FieldOffset(Offset = "0x4")]
      private static readonly ThreadsafeTypeKeyHashTable<MessagePackSerializer.NonGeneric.CompiledMethods> serializes;

      [Token(Token = "0x60012A1")]
      [Address(RVA = "0x3038E0", Offset = "0x3026E0", VA = "0x103038E0")]
      static NonGeneric()
      {
      }

      [Token(Token = "0x60012A2")]
      [Address(RVA = "0x303530", Offset = "0x302330", VA = "0x10303530")]
      public static byte[] Serialize(Type type, object obj) => (byte[]) null;

      [Token(Token = "0x60012A3")]
      [Address(RVA = "0x3034C0", Offset = "0x3022C0", VA = "0x103034C0")]
      public static byte[] Serialize(Type type, object obj, IFormatterResolver resolver)
      {
        return (byte[]) null;
      }

      [Token(Token = "0x60012A4")]
      [Address(RVA = "0x303610", Offset = "0x302410", VA = "0x10303610")]
      public static void Serialize(Type type, Stream stream, object obj)
      {
      }

      [Token(Token = "0x60012A5")]
      [Address(RVA = "0x303450", Offset = "0x302250", VA = "0x10303450")]
      public static void Serialize(
        Type type,
        Stream stream,
        object obj,
        IFormatterResolver resolver)
      {
      }

      [Token(Token = "0x60012A6")]
      [Address(RVA = "0x303760", Offset = "0x302560", VA = "0x10303760")]
      public static int Serialize(
        Type type,
        ref byte[] bytes,
        int offset,
        object value,
        IFormatterResolver resolver)
      {
        return new int();
      }

      [Token(Token = "0x60012A7")]
      [Address(RVA = "0x302FE0", Offset = "0x301DE0", VA = "0x10302FE0")]
      public static object Deserialize(Type type, byte[] bytes) => (object) null;

      [Token(Token = "0x60012A8")]
      [Address(RVA = "0x302BC0", Offset = "0x3019C0", VA = "0x10302BC0")]
      public static object Deserialize(Type type, byte[] bytes, IFormatterResolver resolver)
      {
        return (object) null;
      }

      [Token(Token = "0x60012A9")]
      [Address(RVA = "0x303220", Offset = "0x302020", VA = "0x10303220")]
      public static object Deserialize(Type type, Stream stream) => (object) null;

      [Token(Token = "0x60012AA")]
      [Address(RVA = "0x302CB0", Offset = "0x301AB0", VA = "0x10302CB0")]
      public static object Deserialize(Type type, Stream stream, IFormatterResolver resolver)
      {
        return (object) null;
      }

      [Token(Token = "0x60012AB")]
      [Address(RVA = "0x302D20", Offset = "0x301B20", VA = "0x10302D20")]
      public static object Deserialize(Type type, Stream stream, bool readStrict) => (object) null;

      [Token(Token = "0x60012AC")]
      [Address(RVA = "0x3030C0", Offset = "0x301EC0", VA = "0x103030C0")]
      public static object Deserialize(
        Type type,
        Stream stream,
        IFormatterResolver resolver,
        bool readStrict)
      {
        return (object) null;
      }

      [Token(Token = "0x60012AD")]
      [Address(RVA = "0x302D90", Offset = "0x301B90", VA = "0x10302D90")]
      public static object Deserialize(Type type, ArraySegment<byte> bytes) => (object) null;

      [Token(Token = "0x60012AE")]
      [Address(RVA = "0x302C30", Offset = "0x301A30", VA = "0x10302C30")]
      public static object Deserialize(
        Type type,
        ArraySegment<byte> bytes,
        IFormatterResolver resolver)
      {
        return (object) null;
      }

      [Token(Token = "0x60012AF")]
      [Address(RVA = "0x303130", Offset = "0x301F30", VA = "0x10303130")]
      public static object Deserialize(
        Type type,
        byte[] bytes,
        int offset,
        IFormatterResolver resolver,
        out int readSize)
      {
        return (object) null;
      }

      [Token(Token = "0x60012B0")]
      [Address(RVA = "0x303300", Offset = "0x302100", VA = "0x10303300")]
      private static MessagePackSerializer.NonGeneric.CompiledMethods GetOrAdd(Type type)
      {
        return (MessagePackSerializer.NonGeneric.CompiledMethods) null;
      }

      [Token(Token = "0x2000365")]
      private delegate int RawFormatterSerialize(
        ref byte[] bytes,
        int offset,
        object value,
        IFormatterResolver formatterResolver);

      [Token(Token = "0x2000366")]
      private delegate object RawFormatterDeserialize(
        byte[] bytes,
        int offset,
        IFormatterResolver formatterResolver,
        out int readSize);

      [Token(Token = "0x2000367")]
      private class CompiledMethods
      {
        [Token(Token = "0x4000DC0")]
        [FieldOffset(Offset = "0x8")]
        public readonly Func<object, byte[]> serialize1;
        [Token(Token = "0x4000DC1")]
        [FieldOffset(Offset = "0xC")]
        public readonly Func<object, IFormatterResolver, byte[]> serialize2;
        [Token(Token = "0x4000DC2")]
        [FieldOffset(Offset = "0x10")]
        public readonly Action<Stream, object> serialize3;
        [Token(Token = "0x4000DC3")]
        [FieldOffset(Offset = "0x14")]
        public readonly Action<Stream, object, IFormatterResolver> serialize4;
        [Token(Token = "0x4000DC4")]
        [FieldOffset(Offset = "0x18")]
        public readonly MessagePackSerializer.NonGeneric.RawFormatterSerialize serialize5;
        [Token(Token = "0x4000DC5")]
        [FieldOffset(Offset = "0x1C")]
        public readonly Func<byte[], object> deserialize1;
        [Token(Token = "0x4000DC6")]
        [FieldOffset(Offset = "0x20")]
        public readonly Func<byte[], IFormatterResolver, object> deserialize2;
        [Token(Token = "0x4000DC7")]
        [FieldOffset(Offset = "0x24")]
        public readonly Func<Stream, object> deserialize3;
        [Token(Token = "0x4000DC8")]
        [FieldOffset(Offset = "0x28")]
        public readonly Func<Stream, IFormatterResolver, object> deserialize4;
        [Token(Token = "0x4000DC9")]
        [FieldOffset(Offset = "0x2C")]
        public readonly Func<Stream, bool, object> deserialize5;
        [Token(Token = "0x4000DCA")]
        [FieldOffset(Offset = "0x30")]
        public readonly Func<Stream, IFormatterResolver, bool, object> deserialize6;
        [Token(Token = "0x4000DCB")]
        [FieldOffset(Offset = "0x34")]
        public readonly Func<ArraySegment<byte>, object> deserialize7;
        [Token(Token = "0x4000DCC")]
        [FieldOffset(Offset = "0x38")]
        public readonly Func<ArraySegment<byte>, IFormatterResolver, object> deserialize8;
        [Token(Token = "0x4000DCD")]
        [FieldOffset(Offset = "0x3C")]
        public readonly MessagePackSerializer.NonGeneric.RawFormatterDeserialize deserialize9;

        [Token(Token = "0x60012B9")]
        [Address(RVA = "0x2E8D00", Offset = "0x2E7B00", VA = "0x102E8D00")]
        public CompiledMethods(Type type)
        {
        }

        [Token(Token = "0x60012BA")]
        [Address(RVA = "0x2E8B70", Offset = "0x2E7970", VA = "0x102E8B70")]
        private static MethodInfo GetMethod(Type type, Type[] parameters) => (MethodInfo) null;
      }
    }
  }
}
