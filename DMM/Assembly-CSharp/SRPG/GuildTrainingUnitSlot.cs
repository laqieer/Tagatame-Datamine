// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingUnitSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002544")]
  public class GuildTrainingUnitSlot : UnitIcon
  {
    [Token(Token = "0x400AAD7")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    [HeaderBar("▼GuildTrainingUnitSlot")]
    private Text mTrainingTime;
    [Token(Token = "0x400AAD8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mSlotLock;
    [Token(Token = "0x400AAD9")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject mUnitNull;
    [Token(Token = "0x400AADA")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private SRPG_Button mSelfBtn;
    [Token(Token = "0x400AADB")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Text mUnitPieceAmount;
    [Token(Token = "0x400AADC")]
    [FieldOffset(Offset = "0x60")]
    [HeaderBar("▼文字カラー")]
    [SerializeField]
    private Color UnitTimeFontRed;
    [Token(Token = "0x400AADD")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Color UnitTimeFontBlue;
    [Token(Token = "0x400AADE")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Color UnitTimeFontDefalt;
    [Token(Token = "0x400AADF")]
    [FieldOffset(Offset = "0x90")]
    private GuildTrainingData mGuildTrainingData;
    [Token(Token = "0x400AAE0")]
    [FieldOffset(Offset = "0x94")]
    private GuildTrainingUnit mGuildTrainingUnit;
    [Token(Token = "0x400AAE1")]
    [FieldOffset(Offset = "0x98")]
    private bool mIsLock;
    [Token(Token = "0x400AAE2")]
    [FieldOffset(Offset = "0x99")]
    private bool mIsTrainingNow;
    [Token(Token = "0x400AAE3")]
    [FieldOffset(Offset = "0x9C")]
    private string mTimeFormat;
    [Token(Token = "0x400AAE4")]
    [FieldOffset(Offset = "0xA0")]
    private TimeSpan mRestTrainingTime;
    [Token(Token = "0x400AAE5")]
    [FieldOffset(Offset = "0xA8")]
    private DateTime StartClientDate;

    [Token(Token = "0x600A44E")]
    [Address(RVA = "0x663200", Offset = "0x662000", VA = "0x10663200")]
    private void Start()
    {
    }

    [Token(Token = "0x600A44F")]
    [Address(RVA = "0x662D80", Offset = "0x661B80", VA = "0x10662D80")]
    public void SetUp(
      GuildTrainingData data,
      int now_energy,
      bool is_lock,
      GuildTrainingUnit training_unit,
      bool isAddFrame = false,
      bool is_update_time = true)
    {
    }

    [Token(Token = "0x600A450")]
    [Address(RVA = "0x663380", Offset = "0x662180", VA = "0x10663380")]
    public void UpdateTime(int now_energy)
    {
    }

    [Token(Token = "0x600A451")]
    [Address(RVA = "0x662C30", Offset = "0x661A30", VA = "0x10662C30")]
    public bool IsTrainingFinish() => new bool();

    [Token(Token = "0x600A452")]
    [Address(RVA = "0x662CE0", Offset = "0x661AE0", VA = "0x10662CE0")]
    public void SetTextColor(Color text_color)
    {
    }

    [Token(Token = "0x600A453")]
    [Address(RVA = "0x662C10", Offset = "0x661A10", VA = "0x10662C10")]
    private int GetSlotNo() => new int();

    [Token(Token = "0x600A454")]
    [Address(RVA = "0x663710", Offset = "0x662510", VA = "0x10663710")]
    public GuildTrainingUnitSlot()
    {
    }
  }
}
