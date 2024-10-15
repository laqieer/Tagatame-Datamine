// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitJobListModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033CE")]
  public class UnitJobListModel
  {
    [Token(Token = "0x400F563")]
    [FieldOffset(Offset = "0x8")]
    private readonly string HIDE_JOB_NAME;
    [Token(Token = "0x400F564")]
    protected const int CurrentJob = -1;
    [Token(Token = "0x400F565")]
    [FieldOffset(Offset = "0xC")]
    protected bool mIsEdit;
    [Token(Token = "0x400F566")]
    [FieldOffset(Offset = "0xD")]
    protected bool mIsHide;
    [Token(Token = "0x400F567")]
    [FieldOffset(Offset = "0x10")]
    private int mJobIndex;
    [Token(Token = "0x400F568")]
    [FieldOffset(Offset = "0x14")]
    private string mJobIcon;
    [Token(Token = "0x400F569")]
    [FieldOffset(Offset = "0x18")]
    private string mJobName;

    [Token(Token = "0x17002100")]
    public bool IsEdit
    {
      [Token(Token = "0x600E7DE"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002101")]
    public bool IsHide
    {
      [Token(Token = "0x600E7DF"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002102")]
    public int JobIndex
    {
      [Token(Token = "0x600E7E0"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002103")]
    public string JobIcon
    {
      [Token(Token = "0x600E7E1"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002104")]
    public string JobName
    {
      [Token(Token = "0x600E7E2"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E7E3")]
    [Address(RVA = "0xAD06F0", Offset = "0xACF4F0", VA = "0x10AD06F0")]
    public UnitJobListModel(bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x600E7E4")]
    [Address(RVA = "0xAD05A0", Offset = "0xACF3A0", VA = "0x10AD05A0", Slot = "4")]
    public virtual void Initialize(UnitData unitData)
    {
    }

    [Token(Token = "0x600E7E5")]
    [Address(RVA = "0xAD05C0", Offset = "0xACF3C0", VA = "0x10AD05C0")]
    public void Initialize(UnitData unitData, int index)
    {
    }

    [Token(Token = "0x600E7E6")]
    [Address(RVA = "0xAD05D0", Offset = "0xACF3D0", VA = "0x10AD05D0")]
    public void SetJobData(UnitData unitData, int index = -1)
    {
    }
  }
}
