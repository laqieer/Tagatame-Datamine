// Decompiled with JetBrains decompiler
// Type: MessagePack.MessagePackCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x2000360")]
  public static class MessagePackCode
  {
    [Token(Token = "0x4000D89")]
    public const byte MinFixInt = 0;
    [Token(Token = "0x4000D8A")]
    public const byte MaxFixInt = 127;
    [Token(Token = "0x4000D8B")]
    public const byte MinFixMap = 128;
    [Token(Token = "0x4000D8C")]
    public const byte MaxFixMap = 143;
    [Token(Token = "0x4000D8D")]
    public const byte MinFixArray = 144;
    [Token(Token = "0x4000D8E")]
    public const byte MaxFixArray = 159;
    [Token(Token = "0x4000D8F")]
    public const byte MinFixStr = 160;
    [Token(Token = "0x4000D90")]
    public const byte MaxFixStr = 191;
    [Token(Token = "0x4000D91")]
    public const byte Nil = 192;
    [Token(Token = "0x4000D92")]
    public const byte NeverUsed = 193;
    [Token(Token = "0x4000D93")]
    public const byte False = 194;
    [Token(Token = "0x4000D94")]
    public const byte True = 195;
    [Token(Token = "0x4000D95")]
    public const byte Bin8 = 196;
    [Token(Token = "0x4000D96")]
    public const byte Bin16 = 197;
    [Token(Token = "0x4000D97")]
    public const byte Bin32 = 198;
    [Token(Token = "0x4000D98")]
    public const byte Ext8 = 199;
    [Token(Token = "0x4000D99")]
    public const byte Ext16 = 200;
    [Token(Token = "0x4000D9A")]
    public const byte Ext32 = 201;
    [Token(Token = "0x4000D9B")]
    public const byte Float32 = 202;
    [Token(Token = "0x4000D9C")]
    public const byte Float64 = 203;
    [Token(Token = "0x4000D9D")]
    public const byte UInt8 = 204;
    [Token(Token = "0x4000D9E")]
    public const byte UInt16 = 205;
    [Token(Token = "0x4000D9F")]
    public const byte UInt32 = 206;
    [Token(Token = "0x4000DA0")]
    public const byte UInt64 = 207;
    [Token(Token = "0x4000DA1")]
    public const byte Int8 = 208;
    [Token(Token = "0x4000DA2")]
    public const byte Int16 = 209;
    [Token(Token = "0x4000DA3")]
    public const byte Int32 = 210;
    [Token(Token = "0x4000DA4")]
    public const byte Int64 = 211;
    [Token(Token = "0x4000DA5")]
    public const byte FixExt1 = 212;
    [Token(Token = "0x4000DA6")]
    public const byte FixExt2 = 213;
    [Token(Token = "0x4000DA7")]
    public const byte FixExt4 = 214;
    [Token(Token = "0x4000DA8")]
    public const byte FixExt8 = 215;
    [Token(Token = "0x4000DA9")]
    public const byte FixExt16 = 216;
    [Token(Token = "0x4000DAA")]
    public const byte Str8 = 217;
    [Token(Token = "0x4000DAB")]
    public const byte Str16 = 218;
    [Token(Token = "0x4000DAC")]
    public const byte Str32 = 219;
    [Token(Token = "0x4000DAD")]
    public const byte Array16 = 220;
    [Token(Token = "0x4000DAE")]
    public const byte Array32 = 221;
    [Token(Token = "0x4000DAF")]
    public const byte Map16 = 222;
    [Token(Token = "0x4000DB0")]
    public const byte Map32 = 223;
    [Token(Token = "0x4000DB1")]
    public const byte MinNegativeFixInt = 224;
    [Token(Token = "0x4000DB2")]
    public const byte MaxNegativeFixInt = 255;
    [Token(Token = "0x4000DB3")]
    [FieldOffset(Offset = "0x0")]
    private static readonly MessagePackType[] typeLookupTable;
    [Token(Token = "0x4000DB4")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string[] formatNameTable;

    [Token(Token = "0x600127D")]
    [Address(RVA = "0x2FFAB0", Offset = "0x2FE8B0", VA = "0x102FFAB0")]
    static MessagePackCode()
    {
    }

    [Token(Token = "0x600127E")]
    [Address(RVA = "0x2FFA50", Offset = "0x2FE850", VA = "0x102FFA50")]
    public static MessagePackType ToMessagePackType(byte code) => new MessagePackType();

    [Token(Token = "0x600127F")]
    [Address(RVA = "0x2FF9F0", Offset = "0x2FE7F0", VA = "0x102FF9F0")]
    public static string ToFormatName(byte code) => (string) null;
  }
}
