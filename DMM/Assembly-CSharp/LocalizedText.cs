// Decompiled with JetBrains decompiler
// Type: LocalizedText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x200010E")]
public static class LocalizedText
{
  [Token(Token = "0x40004F3")]
  [FieldOffset(Offset = "0x0")]
  private static bool s_UseAssetManager;
  [Token(Token = "0x40004F4")]
  public const int BYTE_SIZE_FOR_AUTO_UNLOAD = 307200;
  [Token(Token = "0x40004F5")]
  [FieldOffset(Offset = "0x4")]
  private static List<LocalizedText.TextTable> mTables;
  [Token(Token = "0x40004F6")]
  [FieldOffset(Offset = "0x8")]
  private static string mLanguageCode;

  [Token(Token = "0x17000112")]
  public static bool UseAssetManager
  {
    [Token(Token = "0x60006E0"), Address(RVA = "0xD5D340", Offset = "0xD5C140", VA = "0x10D5D340")] get
    {
      return new bool();
    }
    [Token(Token = "0x60006E1"), Address(RVA = "0xD5D3E0", Offset = "0xD5C1E0", VA = "0x10D5D3E0")] set
    {
    }
  }

  [Token(Token = "0x17000113")]
  public static List<LocalizedText.TextTable> Tables
  {
    [Token(Token = "0x60006E2"), Address(RVA = "0xD5D300", Offset = "0xD5C100", VA = "0x10D5D300")] get
    {
      return (List<LocalizedText.TextTable>) null;
    }
  }

  [Token(Token = "0x17000114")]
  public static string LanguageCode
  {
    [Token(Token = "0x60006E3"), Address(RVA = "0xD5D2C0", Offset = "0xD5C0C0", VA = "0x10D5D2C0")] get
    {
      return (string) null;
    }
    [Token(Token = "0x60006E4"), Address(RVA = "0xD5D380", Offset = "0xD5C180", VA = "0x10D5D380")] set
    {
    }
  }

  [Token(Token = "0x60006E5")]
  [Address(RVA = "0xD5B9C0", Offset = "0xD5A7C0", VA = "0x10D5B9C0")]
  private static LocalizedText.TextTable FindTable(string tableID)
  {
    return (LocalizedText.TextTable) null;
  }

  [Token(Token = "0x60006E6")]
  [Address(RVA = "0xD5C360", Offset = "0xD5B160", VA = "0x10D5C360")]
  public static bool HasTextTable(string tableID) => new bool();

  [Token(Token = "0x60006E7")]
  [Address(RVA = "0xD5B950", Offset = "0xD5A750", VA = "0x10D5B950")]
  public static string ComposeTablePath(string tableID) => (string) null;

  [Token(Token = "0x60006E8")]
  [Address(RVA = "0xD5BBD0", Offset = "0xD5A9D0", VA = "0x10D5BBD0")]
  public static int GetAllTextByteSize() => new int();

  [Token(Token = "0x60006E9")]
  [Address(RVA = "0xD5C490", Offset = "0xD5B290", VA = "0x10D5C490")]
  private static LocalizedText.TextTable InternalLoadTable(
    string tableID,
    LocalizedText.TextTable overwriteTable = null)
  {
    return (LocalizedText.TextTable) null;
  }

  [Token(Token = "0x60006EA")]
  [Address(RVA = "0xD5D0F0", Offset = "0xD5BEF0", VA = "0x10D5D0F0")]
  public static void UnloadAllTables()
  {
  }

  [Token(Token = "0x60006EB")]
  [Address(RVA = "0xD5D170", Offset = "0xD5BF70", VA = "0x10D5D170")]
  public static void UnloadTable(string tableID)
  {
  }

  [Token(Token = "0x60006EC")]
  [Address(RVA = "0xD5BD40", Offset = "0xD5AB40", VA = "0x10D5BD40")]
  public static string[] GetTextIDs(string tableID) => (string[]) null;

  [Token(Token = "0x60006ED")]
  [Address(RVA = "0xD5CA30", Offset = "0xD5B830", VA = "0x10D5CA30")]
  public static void LoadTable(string tableID, bool forceReload = false)
  {
  }

  [Token(Token = "0x60006EE")]
  [Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x10D5BCB0")]
  public static string GetResourcePath(string key) => (string) null;

  [Token(Token = "0x60006EF")]
  [Address(RVA = "0xD5C280", Offset = "0xD5B080", VA = "0x10D5C280")]
  public static string Get(string formatKey, params object[] args) => (string) null;

  [Token(Token = "0x60006F0")]
  [Address(RVA = "0xD5C310", Offset = "0xD5B110", VA = "0x10D5C310")]
  public static string Get(string key) => (string) null;

  [Token(Token = "0x60006F1")]
  [Address(RVA = "0xD5CAC0", Offset = "0xD5B8C0", VA = "0x10D5CAC0")]
  public static string ReplaceTag(string text) => (string) null;

  [Token(Token = "0x60006F2")]
  [Address(RVA = "0xD5BE20", Offset = "0xD5AC20", VA = "0x10D5BE20")]
  public static string Get(string key, ref bool success) => (string) null;

  [Token(Token = "0x60006F3")]
  [Address(RVA = "0xD5D200", Offset = "0xD5C000", VA = "0x10D5D200")]
  static LocalizedText()
  {
  }

  [Token(Token = "0x200010F")]
  private class TableUnloader
  {
    [Token(Token = "0x60006F4")]
    [Address(RVA = "0xD68A60", Offset = "0xD67860", VA = "0x10D68A60", Slot = "1")]
    ~TableUnloader()
    {
    }

    [Token(Token = "0x60006F5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TableUnloader()
    {
    }
  }

  [Token(Token = "0x2000110")]
  public class TextTable
  {
    [Token(Token = "0x40004F7")]
    [FieldOffset(Offset = "0x8")]
    public string TableID;
    [Token(Token = "0x40004F8")]
    [FieldOffset(Offset = "0xC")]
    public int HashCode;
    [Token(Token = "0x40004F9")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<string, string> Items;
    [Token(Token = "0x40004FA")]
    [FieldOffset(Offset = "0x14")]
    public bool DonotUnload;
    [Token(Token = "0x40004FB")]
    [FieldOffset(Offset = "0x18")]
    public int ByteSize;

    [Token(Token = "0x60006F6")]
    [Address(RVA = "0xD68C70", Offset = "0xD67A70", VA = "0x10D68C70")]
    public TextTable(string tableID)
    {
    }

    [Token(Token = "0x60006F7")]
    [Address(RVA = "0xD68BF0", Offset = "0xD679F0", VA = "0x10D68BF0")]
    public string FindText(string key) => (string) null;
  }
}
