// Decompiled with JetBrains decompiler
// Type: SRPG.Models.TruthEquipmentStatusListModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033C4")]
  public class TruthEquipmentStatusListModel
  {
    [Token(Token = "0x400F519")]
    [FieldOffset(Offset = "0x8")]
    private BaseStatus _baseStatusAdd;
    [Token(Token = "0x400F51A")]
    [FieldOffset(Offset = "0xC")]
    private BaseStatus _baseStatusScale;
    [Token(Token = "0x400F51B")]
    [FieldOffset(Offset = "0x10")]
    private bool _isGetAbility;
    [Token(Token = "0x400F51C")]
    [FieldOffset(Offset = "0x11")]
    private bool _isOverwriteAbility;
    [Token(Token = "0x400F51D")]
    [FieldOffset(Offset = "0x14")]
    private int _level;

    [Token(Token = "0x170020E0")]
    public BaseStatus BaseStatusAdd
    {
      [Token(Token = "0x600E791"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (BaseStatus) null;
      }
    }

    [Token(Token = "0x170020E1")]
    public BaseStatus BaseStatusScale
    {
      [Token(Token = "0x600E792"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (BaseStatus) null;
      }
    }

    [Token(Token = "0x170020E2")]
    public bool IsGetAbility
    {
      [Token(Token = "0x600E793"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020E3")]
    public bool IsOverwriteAbility
    {
      [Token(Token = "0x600E794"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020E4")]
    public int Level
    {
      [Token(Token = "0x600E795"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E796")]
    [Address(RVA = "0xACD560", Offset = "0xACC360", VA = "0x10ACD560")]
    public void Initialize(UnitData unitData, int level)
    {
    }

    [Token(Token = "0x600E797")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TruthEquipmentStatusListModel()
    {
    }
  }
}
