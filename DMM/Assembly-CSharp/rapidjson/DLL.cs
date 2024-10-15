// Decompiled with JetBrains decompiler
// Type: rapidjson.DLL
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace rapidjson
{
  [Token(Token = "0x200351C")]
  internal static class DLL
  {
    [Token(Token = "0x400FC14")]
    private const string LIBNAME = "rapidjson";

    [Token(Token = "0x600EADA")]
    [Address(RVA = "0xAE7B20", Offset = "0xAE6920", VA = "0x10AE7B20")]
    public static bool TryGet(ref IntPtr src, string name, out IntPtr dst) => new bool();

    [Token(Token = "0x600EADB")]
    [Address(RVA = "0xAE7AB0", Offset = "0xAE68B0", VA = "0x10AE7AB0")]
    public static IntPtr Get(ref IntPtr src, string name) => new IntPtr();

    [Token(Token = "0x600EADC")]
    [Address(RVA = "0xAE79B0", Offset = "0xAE67B0", VA = "0x10AE79B0")]
    public static IntPtr Get(ref IntPtr src, uint index) => new IntPtr();

    [Token(Token = "0x600EADD")]
    [Address(RVA = "0xAE8800", Offset = "0xAE7600", VA = "0x10AE8800")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_new_document_from_memory_bytes(
      byte[] bytes,
      uint length,
      out IntPtr document);

    [Token(Token = "0x600EADE")]
    [Address(RVA = "0xAE8880", Offset = "0xAE7680", VA = "0x10AE8880")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_new_document_from_memory_string(
      string json,
      out IntPtr document);

    [Token(Token = "0x600EADF")]
    [Address(RVA = "0xAE8770", Offset = "0xAE7570", VA = "0x10AE8770")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_new_document_from_file(
      string filepath,
      out IntPtr document);

    [Token(Token = "0x600EAE0")]
    [Address(RVA = "0xAE7C40", Offset = "0xAE6A40", VA = "0x10AE7C40")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern void _rapidjson_delete_document(out IntPtr document);

    [Token(Token = "0x600EAE1")]
    [Address(RVA = "0xAE8230", Offset = "0xAE7030", VA = "0x10AE8230")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_value_by_object(
      IntPtr src,
      string name,
      out bool isObject,
      out IntPtr dst);

    [Token(Token = "0x600EAE2")]
    [Address(RVA = "0xAE7FE0", Offset = "0xAE6DE0", VA = "0x10AE7FE0")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_object_member_count(IntPtr src, out uint size);

    [Token(Token = "0x600EAE3")]
    [Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x10AE7F40")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_key_value_pair_by_object_index(
      IntPtr src,
      uint index,
      out string key,
      out IntPtr value);

    [Token(Token = "0x600EAE4")]
    [Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x10AE81C0")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_value_by_array(
      IntPtr src,
      uint index,
      out bool isArray,
      out IntPtr dst);

    [Token(Token = "0x600EAE5")]
    [Address(RVA = "0xAE7CA0", Offset = "0xAE6AA0", VA = "0x10AE7CA0")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_array_iterator(
      IntPtr src,
      out IntPtr elementsPointer,
      out uint size,
      out uint elementSize);

    [Token(Token = "0x600EAE6")]
    [Address(RVA = "0xAE7ED0", Offset = "0xAE6CD0", VA = "0x10AE7ED0")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_int(IntPtr src, out int dst);

    [Token(Token = "0x600EAE7")]
    [Address(RVA = "0xAE8150", Offset = "0xAE6F50", VA = "0x10AE8150")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_uint(IntPtr src, out uint dst);

    [Token(Token = "0x600EAE8")]
    [Address(RVA = "0xAE7E60", Offset = "0xAE6C60", VA = "0x10AE7E60")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_int64(IntPtr src, out long dst);

    [Token(Token = "0x600EAE9")]
    [Address(RVA = "0xAE80E0", Offset = "0xAE6EE0", VA = "0x10AE80E0")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_uint64(IntPtr src, out ulong dst);

    [Token(Token = "0x600EAEA")]
    [Address(RVA = "0xAE7DF0", Offset = "0xAE6BF0", VA = "0x10AE7DF0")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_float(IntPtr src, out float dst);

    [Token(Token = "0x600EAEB")]
    [Address(RVA = "0xAE7D80", Offset = "0xAE6B80", VA = "0x10AE7D80")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_double(IntPtr src, out double dst);

    [Token(Token = "0x600EAEC")]
    [Address(RVA = "0xAE8050", Offset = "0xAE6E50", VA = "0x10AE8050")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_string(IntPtr src, out string dst);

    [Token(Token = "0x600EAED")]
    [Address(RVA = "0xAE7D10", Offset = "0xAE6B10", VA = "0x10AE7D10")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_bool(IntPtr src, out bool dst);

    [Token(Token = "0x600EAEE")]
    [Address(RVA = "0xAE8350", Offset = "0xAE7150", VA = "0x10AE8350")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_is_array(IntPtr src);

    [Token(Token = "0x600EAEF")]
    [Address(RVA = "0xAE85F0", Offset = "0xAE73F0", VA = "0x10AE85F0")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_is_object(IntPtr src);

    [Token(Token = "0x600EAF0")]
    [Address(RVA = "0xAE8530", Offset = "0xAE7330", VA = "0x10AE8530")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_is_int(IntPtr src);

    [Token(Token = "0x600EAF1")]
    [Address(RVA = "0xAE8710", Offset = "0xAE7510", VA = "0x10AE8710")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_is_uint(IntPtr src);

    [Token(Token = "0x600EAF2")]
    [Address(RVA = "0xAE84D0", Offset = "0xAE72D0", VA = "0x10AE84D0")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_is_int64(IntPtr src);

    [Token(Token = "0x600EAF3")]
    [Address(RVA = "0xAE86B0", Offset = "0xAE74B0", VA = "0x10AE86B0")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_is_uint64(IntPtr src);

    [Token(Token = "0x600EAF4")]
    [Address(RVA = "0xAE8470", Offset = "0xAE7270", VA = "0x10AE8470")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_is_float(IntPtr src);

    [Token(Token = "0x600EAF5")]
    [Address(RVA = "0xAE8410", Offset = "0xAE7210", VA = "0x10AE8410")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_is_double(IntPtr src);

    [Token(Token = "0x600EAF6")]
    [Address(RVA = "0xAE8650", Offset = "0xAE7450", VA = "0x10AE8650")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_is_string(IntPtr src);

    [Token(Token = "0x600EAF7")]
    [Address(RVA = "0xAE83B0", Offset = "0xAE71B0", VA = "0x10AE83B0")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_is_bool(IntPtr src);

    [Token(Token = "0x600EAF8")]
    [Address(RVA = "0xAE8590", Offset = "0xAE7390", VA = "0x10AE8590")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_is_null(IntPtr src);

    [Token(Token = "0x600EAF9")]
    [Address(RVA = "0xAE82C0", Offset = "0xAE70C0", VA = "0x10AE82C0")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    public static extern bool _rapidjson_get_value_by_pointer(
      IntPtr src,
      string pointer,
      uint pointerLength,
      out bool isValid,
      out IntPtr dst);
  }
}
