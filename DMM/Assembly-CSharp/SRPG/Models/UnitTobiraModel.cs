// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitTobiraModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033C2")]
  public class UnitTobiraModel
  {
    [Token(Token = "0x400F50F")]
    [FieldOffset(Offset = "0x8")]
    private UnitData unitdata;
    [Token(Token = "0x400F510")]
    [FieldOffset(Offset = "0xC")]
    private TobiraParam.Category category;
    [Token(Token = "0x400F511")]
    [FieldOffset(Offset = "0x10")]
    private TobiraParam tobiraParam;
    [Token(Token = "0x400F512")]
    [FieldOffset(Offset = "0x14")]
    private TobiraData tobiraData;
    [Token(Token = "0x400F513")]
    [FieldOffset(Offset = "0x18")]
    private bool openable;

    [Token(Token = "0x170020D5")]
    public UnitData Unitdata
    {
      [Token(Token = "0x600E780"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x170020D6")]
    public TobiraParam.Category Category
    {
      [Token(Token = "0x600E781"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new TobiraParam.Category();
      }
    }

    [Token(Token = "0x170020D7")]
    public TobiraData TobiraData
    {
      [Token(Token = "0x600E782"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (TobiraData) null;
      }
    }

    [Token(Token = "0x170020D8")]
    public bool Select
    {
      [Token(Token = "0x600E783"), Address(RVA = "0x3FE5C0", Offset = "0x3FD3C0", VA = "0x103FE5C0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E784"), Address(RVA = "0x4082C0", Offset = "0x4070C0", VA = "0x104082C0")] set
      {
      }
    }

    [Token(Token = "0x170020D9")]
    public bool IsLock
    {
      [Token(Token = "0x600E785"), Address(RVA = "0xAD4130", Offset = "0xAD2F30", VA = "0x10AD4130")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020DA")]
    public bool IsUnlocked
    {
      [Token(Token = "0x600E786"), Address(RVA = "0xAD4150", Offset = "0xAD2F50", VA = "0x10AD4150")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020DB")]
    public bool Openable
    {
      [Token(Token = "0x600E787"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E788")]
    [Address(RVA = "0xAD3FE0", Offset = "0xAD2DE0", VA = "0x10AD3FE0")]
    public void Initialize(UnitData unit, TobiraParam.Category _category)
    {
    }

    [Token(Token = "0x600E789")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitTobiraModel()
    {
    }
  }
}
