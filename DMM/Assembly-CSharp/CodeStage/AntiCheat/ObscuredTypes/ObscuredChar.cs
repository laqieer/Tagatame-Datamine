// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredChar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x200368B")]
  [Serializable]
  public struct ObscuredChar : 
    IEquatable<ObscuredChar>,
    IComparable<ObscuredChar>,
    IComparable<char>,
    IComparable
  {
    [Token(Token = "0x400FFDD")]
    [FieldOffset(Offset = "0x0")]
    private static char cryptoKey;
    [Token(Token = "0x400FFDE")]
    [FieldOffset(Offset = "0x0")]
    private char currentCryptoKey;
    [Token(Token = "0x400FFDF")]
    [FieldOffset(Offset = "0x2")]
    private char hiddenValue;
    [Token(Token = "0x400FFE0")]
    [FieldOffset(Offset = "0x4")]
    private bool inited;
    [Token(Token = "0x400FFE1")]
    [FieldOffset(Offset = "0x6")]
    private char fakeValue;
    [Token(Token = "0x400FFE2")]
    [FieldOffset(Offset = "0x8")]
    private bool fakeValueActive;

    [Token(Token = "0x600F45D")]
    [Address(RVA = "0xB49760", Offset = "0xB48560", VA = "0x10B49760")]
    private ObscuredChar(char value)
    {
    }

    [Token(Token = "0x600F45E")]
    [Address(RVA = "0xB495D0", Offset = "0xB483D0", VA = "0x10B495D0")]
    public static void SetNewCryptoKey(char newKey)
    {
    }

    [Token(Token = "0x600F45F")]
    [Address(RVA = "0xB48F20", Offset = "0xB47D20", VA = "0x10B48F20")]
    public static char EncryptDecrypt(char value) => new char();

    [Token(Token = "0x600F460")]
    [Address(RVA = "0xB48FA0", Offset = "0xB47DA0", VA = "0x10B48FA0")]
    public static char EncryptDecrypt(char value, char key) => new char();

    [Token(Token = "0x600F461")]
    [Address(RVA = "0xB49120", Offset = "0xB47F20", VA = "0x10B49120")]
    public static ObscuredChar FromEncrypted(char encrypted) => new ObscuredChar();

    [Token(Token = "0x600F462")]
    [Address(RVA = "0xB48CF0", Offset = "0xB47AF0", VA = "0x10B48CF0")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F463")]
    [Address(RVA = "0xB49380", Offset = "0xB48180", VA = "0x10B49380")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F464")]
    [Address(RVA = "0xB491D0", Offset = "0xB47FD0", VA = "0x10B491D0")]
    public char GetEncrypted() => new char();

    [Token(Token = "0x600F465")]
    [Address(RVA = "0xB49460", Offset = "0xB48260", VA = "0x10B49460")]
    public void SetEncrypted(char encrypted)
    {
    }

    [Token(Token = "0x600F466")]
    [Address(RVA = "0xB49180", Offset = "0xB47F80", VA = "0x10B49180")]
    public char GetDecrypted() => new char();

    [Token(Token = "0x600F467")]
    [Address(RVA = "0xB492A0", Offset = "0xB480A0", VA = "0x10B492A0")]
    private char InternalDecrypt() => new char();

    [Token(Token = "0x600F468")]
    [Address(RVA = "0xB49910", Offset = "0xB48710", VA = "0x10B49910")]
    public static implicit operator ObscuredChar(char value) => new ObscuredChar();

    [Token(Token = "0x600F469")]
    [Address(RVA = "0xB498C0", Offset = "0xB486C0", VA = "0x10B498C0")]
    public static implicit operator char(ObscuredChar value) => new char();

    [Token(Token = "0x600F46A")]
    [Address(RVA = "0xB49940", Offset = "0xB48740", VA = "0x10B49940")]
    public static ObscuredChar operator ++(ObscuredChar input) => new ObscuredChar();

    [Token(Token = "0x600F46B")]
    [Address(RVA = "0xB497F0", Offset = "0xB485F0", VA = "0x10B497F0")]
    public static ObscuredChar operator --(ObscuredChar input) => new ObscuredChar();

    [Token(Token = "0x600F46C")]
    [Address(RVA = "0xB49220", Offset = "0xB48020", VA = "0x10B49220", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F46D")]
    [Address(RVA = "0xB49630", Offset = "0xB48430", VA = "0x10B49630", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F46E")]
    [Address(RVA = "0xB496B0", Offset = "0xB484B0", VA = "0x10B496B0")]
    public string ToString(IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F46F")]
    [Address(RVA = "0xB49080", Offset = "0xB47E80", VA = "0x10B49080", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F470")]
    [Address(RVA = "0xB49000", Offset = "0xB47E00", VA = "0x10B49000", Slot = "4")]
    public bool Equals(ObscuredChar obj) => new bool();

    [Token(Token = "0x600F471")]
    [Address(RVA = "0xB48E90", Offset = "0xB47C90", VA = "0x10B48E90", Slot = "5")]
    public int CompareTo(ObscuredChar other) => new int();

    [Token(Token = "0x600F472")]
    [Address(RVA = "0xB48D90", Offset = "0xB47B90", VA = "0x10B48D90", Slot = "6")]
    public int CompareTo(char other) => new int();

    [Token(Token = "0x600F473")]
    [Address(RVA = "0xB48E10", Offset = "0xB47C10", VA = "0x10B48E10", Slot = "7")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F474")]
    [Address(RVA = "0xB49730", Offset = "0xB48530", VA = "0x10B49730")]
    static ObscuredChar()
    {
    }
  }
}
