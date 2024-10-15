// Decompiled with JetBrains decompiler
// Type: SRPG.VersusFreeMatchInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200274C")]
  [AddComponentMenu("UI/Multi/Versus/VersusFreeMatchInfo")]
  public class VersusFreeMatchInfo : MonoBehaviour
  {
    [Token(Token = "0x400B98B")]
    [FieldOffset(Offset = "0xC")]
    private readonly float UPDATE_WAIT_TIME;
    [Token(Token = "0x400B98C")]
    [FieldOffset(Offset = "0x10")]
    [Description("開催中のときに表示するオブジェクトルート")]
    public GameObject OpenRoot;
    [Token(Token = "0x400B98D")]
    [FieldOffset(Offset = "0x14")]
    [Description("開催していないときに表示するオブジェクトルート")]
    public GameObject CloseRoot;
    [Token(Token = "0x400B98E")]
    [FieldOffset(Offset = "0x18")]
    [Description("連勝数オブジェクト")]
    public GameObject StreakWin;
    [Token(Token = "0x400B98F")]
    [FieldOffset(Offset = "0x1C")]
    [Description("獲得コイン回数倍率オブジェクト")]
    public GameObject CoinRate;
    [Token(Token = "0x400B990")]
    [FieldOffset(Offset = "0x20")]
    [Description("開催残り時間")]
    public Text RemainTime;
    [Token(Token = "0x400B991")]
    [FieldOffset(Offset = "0x24")]
    [Description("次回開催までのテキスト")]
    public Text ScheduleTxt;
    [Token(Token = "0x400B992")]
    [FieldOffset(Offset = "0x28")]
    [Description("連勝数")]
    public Text StreakWinTxt;
    [Token(Token = "0x400B993")]
    [FieldOffset(Offset = "0x2C")]
    [Description("コイン倍率")]
    public Text CoinRateTxt;
    [Token(Token = "0x400B994")]
    [FieldOffset(Offset = "0x30")]
    [Description("フリー対戦のボタン")]
    public Button FreeBtn;
    [Token(Token = "0x400B995")]
    [FieldOffset(Offset = "0x34")]
    private float mWaitTime;
    [Token(Token = "0x400B996")]
    [FieldOffset(Offset = "0x38")]
    private long mEndTime;

    [Token(Token = "0x600B056")]
    [Address(RVA = "0x74F980", Offset = "0x74E780", VA = "0x1074F980")]
    private void Start()
    {
    }

    [Token(Token = "0x600B057")]
    [Address(RVA = "0x74F6E0", Offset = "0x74E4E0", VA = "0x1074F6E0")]
    private void RefreshData()
    {
    }

    [Token(Token = "0x600B058")]
    [Address(RVA = "0x74F990", Offset = "0x74E790", VA = "0x1074F990")]
    private void Update()
    {
    }

    [Token(Token = "0x600B059")]
    [Address(RVA = "0x74F2B0", Offset = "0x74E0B0", VA = "0x1074F2B0")]
    private void CountDown()
    {
    }

    [Token(Token = "0x600B05A")]
    [Address(RVA = "0x74EE30", Offset = "0x74DC30", VA = "0x1074EE30")]
    private void Close()
    {
    }

    [Token(Token = "0x600B05B")]
    [Address(RVA = "0x74F9E0", Offset = "0x74E7E0", VA = "0x1074F9E0")]
    public VersusFreeMatchInfo()
    {
    }
  }
}
