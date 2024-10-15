// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePridePieceSelectItemListViewModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033B5")]
  public class RunePridePieceSelectItemListViewModel : BaseItemModel
  {
    [Token(Token = "0x400F4C8")]
    [FieldOffset(Offset = "0x20")]
    private int mSliderValue;
    [Token(Token = "0x400F4C9")]
    [FieldOffset(Offset = "0x24")]
    private int mSliderMin;
    [Token(Token = "0x400F4CA")]
    [FieldOffset(Offset = "0x28")]
    private int mSliderMax;
    [Token(Token = "0x400F4CB")]
    [FieldOffset(Offset = "0x2C")]
    private bool mEnablePlusButton;
    [Token(Token = "0x400F4CC")]
    [FieldOffset(Offset = "0x2D")]
    private bool mEnableMinusButton;
    [Token(Token = "0x400F4CD")]
    [FieldOffset(Offset = "0x30")]
    private int mNeedAmount;

    [Token(Token = "0x17002085")]
    public bool ToggleState
    {
      [Token(Token = "0x600E6FB"), Address(RVA = "0x54FFB0", Offset = "0x54EDB0", VA = "0x1054FFB0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E6FC"), Address(RVA = "0x54FC50", Offset = "0x54EA50", VA = "0x1054FC50")] set
      {
      }
    }

    [Token(Token = "0x17002086")]
    public int SliderValue
    {
      [Token(Token = "0x600E6FD"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002087")]
    public int SliderMin
    {
      [Token(Token = "0x600E6FE"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002088")]
    public int SliderMax
    {
      [Token(Token = "0x600E6FF"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002089")]
    public bool IsEnablePlusButton
    {
      [Token(Token = "0x600E700"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700208A")]
    public bool IsEnableMinusButton
    {
      [Token(Token = "0x600E701"), Address(RVA = "0x34B870", Offset = "0x34A670", VA = "0x1034B870")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700208B")]
    public bool IsOnMask
    {
      [Token(Token = "0x600E702"), Address(RVA = "0x8E4B70", Offset = "0x8E3970", VA = "0x108E4B70")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E703"), Address(RVA = "0xAAFB70", Offset = "0xAAE970", VA = "0x10AAFB70")] set
      {
      }
    }

    [Token(Token = "0x600E704")]
    [Address(RVA = "0xAC6D40", Offset = "0xAC5B40", VA = "0x10AC6D40")]
    public void InitModel(ItemParam item_param, int value, int min, int max, int need_num)
    {
    }

    [Token(Token = "0x600E705")]
    [Address(RVA = "0xAC6DC0", Offset = "0xAC5BC0", VA = "0x10AC6DC0")]
    public void OnChangedPlusButton()
    {
    }

    [Token(Token = "0x600E706")]
    [Address(RVA = "0xAC6DA0", Offset = "0xAC5BA0", VA = "0x10AC6DA0")]
    public void OnChangedMinusButton()
    {
    }

    [Token(Token = "0x600E707")]
    [Address(RVA = "0xAC6DE0", Offset = "0xAC5BE0", VA = "0x10AC6DE0")]
    public void SetSliderValue(int value)
    {
    }

    [Token(Token = "0x600E708")]
    [Address(RVA = "0xAC6D00", Offset = "0xAC5B00", VA = "0x10AC6D00")]
    public void CheckButtonEnable(int use_amount)
    {
    }

    [Token(Token = "0x600E709")]
    [Address(RVA = "0xAC6E10", Offset = "0xAC5C10", VA = "0x10AC6E10")]
    public RunePridePieceSelectItemListViewModel()
    {
    }
  }
}
