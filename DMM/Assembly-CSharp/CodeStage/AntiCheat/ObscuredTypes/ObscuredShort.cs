// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredShort
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x200369B")]
  [Serializable]
  public struct ObscuredShort : 
    IFormattable,
    IEquatable<ObscuredShort>,
    IComparable<ObscuredShort>,
    IComparable<short>,
    IComparable
  {
    [Token(Token = "0x4010045")]
    [FieldOffset(Offset = "0x0")]
    private static short cryptoKey;
    [Token(Token = "0x4010046")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private short currentCryptoKey;
    [Token(Token = "0x4010047")]
    [FieldOffset(Offset = "0x2")]
    [SerializeField]
    private short hiddenValue;
    [Token(Token = "0x4010048")]
    [FieldOffset(Offset = "0x4")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x4010049")]
    [FieldOffset(Offset = "0x6")]
    [SerializeField]
    private short fakeValue;
    [Token(Token = "0x401004A")]
    [FieldOffset(Offset = "0x8")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F5AB")]
    [Address(RVA = "0xB59000", Offset = "0xB57E00", VA = "0x10B59000")]
    private ObscuredShort(short value)
    {
    }

    [Token(Token = "0x600F5AC")]
    [Address(RVA = "0xB58DE0", Offset = "0xB57BE0", VA = "0x10B58DE0")]
    public static void SetNewCryptoKey(short newKey)
    {
    }

    [Token(Token = "0x600F5AD")]
    [Address(RVA = "0xB58750", Offset = "0xB57550", VA = "0x10B58750")]
    public static short EncryptDecrypt(short value) => new short();

    [Token(Token = "0x600F5AE")]
    [Address(RVA = "0xB587D0", Offset = "0xB575D0", VA = "0x10B587D0")]
    public static short EncryptDecrypt(short value, short key) => new short();

    [Token(Token = "0x600F5AF")]
    [Address(RVA = "0xB58950", Offset = "0xB57750", VA = "0x10B58950")]
    public static ObscuredShort FromEncrypted(short encrypted) => new ObscuredShort();

    [Token(Token = "0x600F5B0")]
    [Address(RVA = "0xB58580", Offset = "0xB57380", VA = "0x10B58580")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F5B1")]
    [Address(RVA = "0xB58B90", Offset = "0xB57990", VA = "0x10B58B90")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F5B2")]
    [Address(RVA = "0xB58A00", Offset = "0xB57800", VA = "0x10B58A00")]
    public short GetEncrypted() => new short();

    [Token(Token = "0x600F5B3")]
    [Address(RVA = "0xB58C70", Offset = "0xB57A70", VA = "0x10B58C70")]
    public void SetEncrypted(short encrypted)
    {
    }

    [Token(Token = "0x600F5B4")]
    [Address(RVA = "0xB589B0", Offset = "0xB577B0", VA = "0x10B589B0")]
    public short GetDecrypted() => new short();

    [Token(Token = "0x600F5B5")]
    [Address(RVA = "0xB58AB0", Offset = "0xB578B0", VA = "0x10B58AB0")]
    private short InternalDecrypt() => new short();

    [Token(Token = "0x600F5B6")]
    [Address(RVA = "0xB59120", Offset = "0xB57F20", VA = "0x10B59120")]
    public static implicit operator ObscuredShort(short value) => new ObscuredShort();

    [Token(Token = "0x600F5B7")]
    [Address(RVA = "0xB59150", Offset = "0xB57F50", VA = "0x10B59150")]
    public static implicit operator short(ObscuredShort value) => new short();

    [Token(Token = "0x600F5B8")]
    [Address(RVA = "0xB591A0", Offset = "0xB57FA0", VA = "0x10B591A0")]
    public static ObscuredShort operator ++(ObscuredShort input) => new ObscuredShort();

    [Token(Token = "0x600F5B9")]
    [Address(RVA = "0xB59090", Offset = "0xB57E90", VA = "0x10B59090")]
    public static ObscuredShort operator --(ObscuredShort input) => new ObscuredShort();

    [Token(Token = "0x600F5BA")]
    [Address(RVA = "0xB58A50", Offset = "0xB57850", VA = "0x10B58A50", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F5BB")]
    [Address(RVA = "0xB58EA0", Offset = "0xB57CA0", VA = "0x10B58EA0", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F5BC")]
    [Address(RVA = "0xB58F60", Offset = "0xB57D60", VA = "0x10B58F60")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F5BD")]
    [Address(RVA = "0xB58E40", Offset = "0xB57C40", VA = "0x10B58E40")]
    public string ToString(IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F5BE")]
    [Address(RVA = "0xB58F00", Offset = "0xB57D00", VA = "0x10B58F00", Slot = "4")]
    public string ToString(string format, IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F5BF")]
    [Address(RVA = "0xB58830", Offset = "0xB57630", VA = "0x10B58830", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F5C0")]
    [Address(RVA = "0xB588D0", Offset = "0xB576D0", VA = "0x10B588D0", Slot = "5")]
    public bool Equals(ObscuredShort obj) => new bool();

    [Token(Token = "0x600F5C1")]
    [Address(RVA = "0xB58620", Offset = "0xB57420", VA = "0x10B58620", Slot = "6")]
    public int CompareTo(ObscuredShort other) => new int();

    [Token(Token = "0x600F5C2")]
    [Address(RVA = "0xB58690", Offset = "0xB57490", VA = "0x10B58690", Slot = "7")]
    public int CompareTo(short other) => new int();

    [Token(Token = "0x600F5C3")]
    [Address(RVA = "0xB586F0", Offset = "0xB574F0", VA = "0x10B586F0", Slot = "8")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F5C4")]
    [Address(RVA = "0xB58FC0", Offset = "0xB57DC0", VA = "0x10B58FC0")]
    static ObscuredShort()
    {
    }
  }
}
