// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePridePanelModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033B2")]
  public class RunePridePanelModel
  {
    [Token(Token = "0x400F4A4")]
    private const int END_SQUARE_INDEX = 0;
    [Token(Token = "0x400F4A5")]
    private const int COMING_SOON_SQUARE_INDEX = 1;
    [Token(Token = "0x400F4A6")]
    private const int INDEX_OFF = 0;
    [Token(Token = "0x400F4A7")]
    private const int INDEX_ON = 1;
    [Token(Token = "0x400F4A8")]
    [FieldOffset(Offset = "0x8")]
    private int startLv;
    [Token(Token = "0x400F4A9")]
    [FieldOffset(Offset = "0xC")]
    private bool isLastLv;
    [Token(Token = "0x400F4AA")]
    [FieldOffset(Offset = "0xD")]
    private bool isPanelCleared;
    [Token(Token = "0x400F4AB")]
    [FieldOffset(Offset = "0xE")]
    private bool isExistLateOpenPanel;
    [Token(Token = "0x400F4AC")]
    [FieldOffset(Offset = "0xF")]
    private bool isSelectMultipleMode;
    [Token(Token = "0x400F4AD")]
    [FieldOffset(Offset = "0x10")]
    private bool canSelectGoalSquare;
    [Token(Token = "0x400F4AE")]
    [FieldOffset(Offset = "0x14")]
    private int currentPotentialNum;
    [Token(Token = "0x400F4AF")]
    [FieldOffset(Offset = "0x18")]
    private int potentialMax;

    [Token(Token = "0x17002065")]
    public int StartLv
    {
      [Token(Token = "0x600E6C9"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002066")]
    public bool IsLastLv
    {
      [Token(Token = "0x600E6CA"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002067")]
    public bool IsPanelCleared
    {
      [Token(Token = "0x600E6CB"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002068")]
    public bool CanSelectGoalSquare
    {
      [Token(Token = "0x600E6CC"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002069")]
    public int CurrentPotentialNum
    {
      [Token(Token = "0x600E6CD"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700206A")]
    public int PotentialMax
    {
      [Token(Token = "0x600E6CE"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700206B")]
    public int GoalLvImageArrayIndex
    {
      [Token(Token = "0x600E6CF"), Address(RVA = "0xAC6760", Offset = "0xAC5560", VA = "0x10AC6760")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700206C")]
    public int GoalSquareImageIndex
    {
      [Token(Token = "0x600E6D0"), Address(RVA = "0xAC6860", Offset = "0xAC5660", VA = "0x10AC6860")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700206D")]
    public int SelectMultipleModeImageIndex
    {
      [Token(Token = "0x600E6D1"), Address(RVA = "0xAC6880", Offset = "0xAC5680", VA = "0x10AC6880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E6D2")]
    [Address(RVA = "0xAC6790", Offset = "0xAC5590", VA = "0x10AC6790")]
    public void Initialize(RunePridePanelModel.ViewData data)
    {
    }

    [Token(Token = "0x600E6D3")]
    [Address(RVA = "0xAC6800", Offset = "0xAC5600", VA = "0x10AC6800")]
    public bool SwitchCanSelectGoalSquare(bool canSelectGoalSquare) => new bool();

    [Token(Token = "0x600E6D4")]
    [Address(RVA = "0xAC6820", Offset = "0xAC5620", VA = "0x10AC6820")]
    public bool SwitchSelectMultipleMode(bool isSelectMultipleMode) => new bool();

    [Token(Token = "0x600E6D5")]
    [Address(RVA = "0xAC6840", Offset = "0xAC5640", VA = "0x10AC6840")]
    public bool UpdatePotentialNum(int potentialNum) => new bool();

    [Token(Token = "0x600E6D6")]
    [Address(RVA = "0xAC67D0", Offset = "0xAC55D0", VA = "0x10AC67D0")]
    public bool SetPanelClear(bool isPanelClear) => new bool();

    [Token(Token = "0x600E6D7")]
    [Address(RVA = "0xAC6760", Offset = "0xAC5560", VA = "0x10AC6760")]
    private int GetGoalSquareImageArrayIndex() => new int();

    [Token(Token = "0x600E6D8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePridePanelModel()
    {
    }

    [Token(Token = "0x20033B3")]
    public struct ViewData
    {
      [Token(Token = "0x400F4B0")]
      [FieldOffset(Offset = "0x0")]
      public int StartLv;
      [Token(Token = "0x400F4B1")]
      [FieldOffset(Offset = "0x4")]
      public bool IsLastLv;
      [Token(Token = "0x400F4B2")]
      [FieldOffset(Offset = "0x5")]
      public bool IsPanelCleared;
      [Token(Token = "0x400F4B3")]
      [FieldOffset(Offset = "0x6")]
      public bool IsExistLateOpenPanel;
      [Token(Token = "0x400F4B4")]
      [FieldOffset(Offset = "0x7")]
      public bool CanSelectGoalSquare;
      [Token(Token = "0x400F4B5")]
      [FieldOffset(Offset = "0x8")]
      public int CurrentPotentialNum;
      [Token(Token = "0x400F4B6")]
      [FieldOffset(Offset = "0xC")]
      public int PotentialMax;
      [Token(Token = "0x400F4B7")]
      [FieldOffset(Offset = "0x10")]
      public bool IsSelectMultipleMode;

      [Token(Token = "0x600E6D9")]
      [Address(RVA = "0xAD4F20", Offset = "0xAD3D20", VA = "0x10AD4F20")]
      public ViewData(
        int startLv,
        bool isLastLv,
        bool isPanelCleared,
        bool isExistLateOpenPanel,
        bool canSelectGoalSquare,
        int currentPotentialNum,
        int potentialMax,
        bool isSelectMultipleMode)
      {
      }
    }
  }
}
