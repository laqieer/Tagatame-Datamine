// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureDataBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F86")]
  [MessagePackObject(true)]
  public class AdventureDataBase
  {
    [Token(Token = "0x4008527")]
    [FieldOffset(Offset = "0x8")]
    protected string mAreaIname;
    [Token(Token = "0x4008528")]
    [FieldOffset(Offset = "0xC")]
    protected int mLevel;

    [Token(Token = "0x1700128C")]
    public string AreaIname
    {
      [Token(Token = "0x6008171"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700128D")]
    public int Level
    {
      [Token(Token = "0x6008172"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008173")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdventureDataBase()
    {
    }

    [Token(Token = "0x6008174")]
    [Address(RVA = "0x3217D0", Offset = "0x3205D0", VA = "0x103217D0")]
    public AdventureDataBase(string adb_iname, int lv)
    {
    }

    [Token(Token = "0x6008175")]
    [Address(RVA = "0x372170", Offset = "0x370F70", VA = "0x10372170")]
    public bool Deserialize(JSON_AdventureDataBase json) => new bool();

    [Token(Token = "0x6008176")]
    [Address(RVA = "0x41F590", Offset = "0x41E390", VA = "0x1041F590")]
    public JSON_AdventureDataBase Serialize() => (JSON_AdventureDataBase) null;

    [Token(Token = "0x6008177")]
    [Address(RVA = "0x41F460", Offset = "0x41E260", VA = "0x1041F460")]
    public static AdventureDataBase CreateDummyData() => (AdventureDataBase) null;
  }
}
