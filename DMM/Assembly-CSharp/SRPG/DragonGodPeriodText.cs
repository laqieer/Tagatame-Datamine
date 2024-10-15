// Decompiled with JetBrains decompiler
// Type: SRPG.DragonGodPeriodText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027FB")]
  public class DragonGodPeriodText : MonoBehaviour
  {
    [Token(Token = "0x400BE4E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [Description("期間を表示するテキスト")]
    private Text mText;
    [Token(Token = "0x400BE4F")]
    [FieldOffset(Offset = "0x10")]
    [Description("期間外時に表示する文字")]
    private string mPeriodText;
    [Token(Token = "0x400BE50")]
    [FieldOffset(Offset = "0x14")]
    [Description("期間外は表示を消す")]
    [SerializeField]
    private bool isHide;
    [Token(Token = "0x400BE51")]
    [FieldOffset(Offset = "0x15")]
    [SerializeField]
    [Description("true = 全期間/false = クエスト挑戦可能期間")]
    private bool isAllTime;

    [Token(Token = "0x600B47E")]
    [Address(RVA = "0x7A56C0", Offset = "0x7A44C0", VA = "0x107A56C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B47F")]
    [Address(RVA = "0x7A5A00", Offset = "0x7A4800", VA = "0x107A5A00")]
    public DragonGodPeriodText()
    {
    }
  }
}
