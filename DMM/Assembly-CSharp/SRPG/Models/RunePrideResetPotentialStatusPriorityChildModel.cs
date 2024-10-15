// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePrideResetPotentialStatusPriorityChildModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033B8")]
  public class RunePrideResetPotentialStatusPriorityChildModel : BaseItemModel
  {
    [Token(Token = "0x400F4E0")]
    [FieldOffset(Offset = "0x20")]
    protected bool mIsEnableInfiniteChar;
    [Token(Token = "0x400F4E1")]
    [FieldOffset(Offset = "0x24")]
    protected string mUseCountText;
    [Token(Token = "0x400F4E2")]
    [FieldOffset(Offset = "0x28")]
    protected string mHaveCountText;

    [Token(Token = "0x1700209A")]
    public bool IsEnableInfiniteChar
    {
      [Token(Token = "0x600E726"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700209B")]
    public string UseCountText
    {
      [Token(Token = "0x600E727"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700209C")]
    public string HaveCountText
    {
      [Token(Token = "0x600E728"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E729")]
    [Address(RVA = "0xAC7330", Offset = "0xAC6130", VA = "0x10AC7330")]
    public void Init(string iname, int need_count, int use_num)
    {
    }

    [Token(Token = "0x600E72A")]
    [Address(RVA = "0xAB1770", Offset = "0xAB0570", VA = "0x10AB1770")]
    public RunePrideResetPotentialStatusPriorityChildModel()
    {
    }
  }
}
