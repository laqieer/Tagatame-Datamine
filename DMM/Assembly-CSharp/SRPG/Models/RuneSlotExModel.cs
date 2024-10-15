// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneSlotExModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033A7")]
  public class RuneSlotExModel
  {
    [Token(Token = "0x400F463")]
    [FieldOffset(Offset = "0x8")]
    private BindRuneData mRuneData;
    [Token(Token = "0x400F464")]
    [FieldOffset(Offset = "0xC")]
    private RuneSlotIndex mSlotIndex;
    [Token(Token = "0x400F465")]
    [FieldOffset(Offset = "0xD")]
    private bool mIsSelect;
    [Token(Token = "0x400F466")]
    [FieldOffset(Offset = "0xE")]
    private bool mIsPlayEffect;

    [Token(Token = "0x17002032")]
    public BindRuneData RuneData
    {
      [Token(Token = "0x600E673"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (BindRuneData) null;
      }
    }

    [Token(Token = "0x17002033")]
    public RuneSlotIndex SlotIndex
    {
      [Token(Token = "0x600E674"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new RuneSlotIndex();
      }
    }

    [Token(Token = "0x17002034")]
    public bool IsSelect
    {
      [Token(Token = "0x600E675"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002035")]
    public bool IsPlayEffect
    {
      [Token(Token = "0x600E676"), Address(RVA = "0x3E7F60", Offset = "0x3E6D60", VA = "0x103E7F60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002036")]
    public bool IsEquip
    {
      [Token(Token = "0x600E677"), Address(RVA = "0x39EF50", Offset = "0x39DD50", VA = "0x1039EF50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E678")]
    [Address(RVA = "0xACC650", Offset = "0xACB450", VA = "0x10ACC650")]
    public void Initialize(BindRuneData runeData, RuneSlotIndex slotIndex)
    {
    }

    [Token(Token = "0x600E679")]
    [Address(RVA = "0xACC680", Offset = "0xACB480", VA = "0x10ACC680")]
    public void Setup(BindRuneData runeData, RuneSlotIndex slotIndex, bool isPlayEffect = true)
    {
    }

    [Token(Token = "0x600E67A")]
    [Address(RVA = "0xAC6BB0", Offset = "0xAC59B0", VA = "0x10AC6BB0")]
    public void SetIsPlayEffect(bool isPlayEffect)
    {
    }

    [Token(Token = "0x600E67B")]
    [Address(RVA = "0xACC6B0", Offset = "0xACB4B0", VA = "0x10ACC6B0")]
    public RuneSlotExModel()
    {
    }
  }
}
